using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CampusFeedback.ViewModels;
using DutchTreat.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DutchTreat.Data
{
  public class DutchRepository : IDutchRepository//
  {
    private readonly DutchContext _ctx;
    private readonly ILogger<DutchRepository> _logger;

    public DutchRepository(DutchContext ctx, ILogger<DutchRepository> logger) 
    {
      _ctx = ctx;
      _logger = logger;
    }
    public IEnumerable<Question> GetAllQuestions()
    {
        try
        {
            return _ctx.Questions
                        .ToList();

        }
        catch (Exception ex)
        {
            _logger.LogError($"Failed to get all Questions: {ex}");
            return null;
        }
    }

    public IEnumerable<Question> GetHomePageQuestions()
    {
        try
        {
            return _ctx.Questions.Where(i=>i.IsShowInHomepage)
                        .ToList();

        }
        catch (Exception ex)
        {
            _logger.LogError($"Failed to get all Questions: {ex}");
            return null;
        }
    }

    public int GetNumberOfStudents()
    {
        try
        {
            return _ctx.Students.Count();

        }
        catch (Exception ex)
        {
            _logger.LogError($"Failed to get all Questions: {ex}");
            return 0;
        }
    }

    public IEnumerable<Feedback> GetFeedbackofQuestion(int questionId)
    {
        try
        {
            return _ctx.Feedbacks.Where(x=>x.QuestionId == questionId)
                        .ToList();

        }
        catch (Exception ex)
        {
            _logger.LogError($"Failed to get all Questions: {ex}");
            return null;
        }
    }

    public bool CheckExistingStudent(string universityId, string email)
    {
        try
        {
            return _ctx.Students.Any(x => x.UniversityId.Equals(universityId) || x.Email.Equals(email));

        }
        catch (Exception ex)
        {
            _logger.LogError($"Failed to get all Questions: {ex}");
            return false;
        }
    }

    public Student getStudentInfo(int id)
    {
        try
        {
            return _ctx.Students.FirstOrDefault(x => x.Id == id);
        }
        catch (Exception ex)
        {
            _logger.LogError($"Failed to get this student's Information: {ex}");
            return null;
        }
    }
    public List<Student> getStudentList()
    {
        try
        {
            return _ctx.Students.ToList();
        }
        catch (Exception ex)
        {
            _logger.LogError($"Failed to get this student's : {ex}");
            return null;
        }
    }

    public List<FeedbackView> getStudentFeedback(int studentId)
    {
        try
        {
            var feedbacks = _ctx.Feedbacks.Where(x=>x.StudentId == studentId).ToList();
            List<FeedbackView> feedbackViews = new List<FeedbackView>();
            foreach(var feedback in feedbacks)
            {
                FeedbackView feedbackView = new FeedbackView();
                feedbackView.Id = feedback.Id;
                      feedbackView.StudentId = studentId;
                    feedbackView.UniversityId = _ctx.Students.FirstOrDefault(x => x.Id == studentId).UniversityId;
                    feedbackView.Email = _ctx.Students.FirstOrDefault(x => x.Id == studentId).Email;
                    feedbackView.QuestionTitle = _ctx.Questions.FirstOrDefault(x => x.Id == feedback.QuestionId).Title;
                    feedbackView.Value = feedback.Value;
                    feedbackView.ValueString = getValueString(feedback.Value);

                       feedbackViews.Add(feedbackView);
            }

            return feedbackViews;
        }
        catch (Exception ex)
        {
            _logger.LogError($"Failed to get this student's Feedback : {ex}");
            return null;
        }
    }

    public bool SaveAll()
    {
      return _ctx.SaveChanges() > 0;
    }

    public void AddEntity(object entity)
    {
      _ctx.Add(entity);
    }
    public void UpdateEntity(Question question)
    {
        _ctx.Questions.Update(question);
    }
    public void DeleteEntity(object entity)
    {
        _ctx.Remove(entity);
    }
    private string getValueString(string value)
    {
        switch(value)
        {
            case "1":
                return "Poor";
            case "2":
                return "Average";
            case "3":
                return "Good";
            case "4":
                return "Excellent";

        }
        return "";
    }
  }
}
