using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CampusFeedback.Services;
using CampusFeedback.ViewModels;
using DutchTreat.Data;
using DutchTreat.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;

namespace DutchTreat.Controllers
{
  [Route("api/[Controller]")]
  [ApiController]
  [Produces("application/json")]
  public class QuestionsController : ControllerBase
  {
    private readonly IDutchRepository _repository;
    private readonly IMailService _mailService;
    private readonly ILogger<QuestionsController> _logger;

    public QuestionsController(IDutchRepository repository, IMailService mailService, ILogger<QuestionsController> logger)
    {
      _repository = repository;
      _mailService = mailService;
      _logger = logger;
    }

    [HttpGet("studentCount")]
    [ProducesResponseType(200)]
    public ActionResult<int> StudentCount()
        {
            try
            {
                int numberOfStudents = _repository.GetNumberOfStudents();
                return numberOfStudents;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get total students : {ex}");
                return BadRequest("failed to get total students ");
            }
        }

    [HttpGet]
    [ProducesResponseType(200)]
    [ProducesResponseType(400)]
    public ActionResult<List<QuestionPercentage>> Get()
    {
      try
      {
        List<Question> homePageQuestions = _repository.GetHomePageQuestions().ToList();
        int numberOfStudents = _repository.GetNumberOfStudents();

        List<QuestionPercentage> totalQuestions = new List<QuestionPercentage>();

        foreach(Question question in homePageQuestions)
        {
            List<Feedback> feedbacks = _repository.GetFeedbackofQuestion(question.Id).ToList();


            QuestionPercentage questionPercentage = new QuestionPercentage();

            questionPercentage.QuestionId = question.Id;
            questionPercentage.Q1 = Convert.ToDouble(feedbacks.Where(x => x.Value.Equals("1")).ToList().Count()) / numberOfStudents * 100;
            questionPercentage.Q2 = Convert.ToDouble(feedbacks.Where(x => x.Value.Equals("2")).ToList().Count()) / numberOfStudents * 100;
            questionPercentage.Q3 = Convert.ToDouble(feedbacks.Where(x => x.Value.Equals("3")).ToList().Count()) / numberOfStudents * 100;
            questionPercentage.Q4 = Convert.ToDouble(feedbacks.Where(x => x.Value.Equals("4")).ToList().Count()) / numberOfStudents * 100;
                    
            totalQuestions.Add(questionPercentage);

        }

        return Ok(totalQuestions); 
      }
      catch (Exception ex)
      {
        _logger.LogError($"Failed to get questions: {ex}");
        return BadRequest("failed to get questions");
      }
    }

    [HttpPost]
    public IActionResult Post([FromBody] IEnumerable<Feedback> model)
    {
        try
        {
            if (ModelState.IsValid)
            {
                foreach (var item in model)
                {
                    _repository.AddEntity(item);
                    _repository.SaveAll();
                }
                MailRequest request = new MailRequest();
                request.Subject = "Campus Feedback";
                request.ToEmail = _repository.getStudentInfo(model.First().StudentId).Email;//Fetch email from student table

                    var feedbackViews = _repository.getStudentFeedback(model.First().StudentId);

                    StringBuilder sb = new StringBuilder("<div class=\"container-fluid\">\r\n    <div class=\"container mt-5\"> <h1>Thanks For Your Feedback</h1> <h3>Your feedback is :</h3>");

                    foreach (var feedbackView in feedbackViews)
                    {
                        sb.Append("<div class=\"row mt-5\">\r\n<h4>");
                        sb.Append(feedbackView.QuestionTitle.ToString());
                        sb.Append("</h4>\r\n<p><b>Answer : </b>");
                        sb.Append(feedbackView.ValueString);
                        sb.Append("</p>\r\n </div></div>\r\n</div>");
                    }
                    
                    request.Body = sb.ToString();

                _mailService.SendEmail(request);//Call to mailservice
                return Ok(model);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
        catch (Exception ex)
        {
            _logger.LogError($"Failed to save new feedback: {ex}");
        }

        return BadRequest("Failed to save new feedback.");
    }
  }
}
