using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DutchTreat.Data;
using DutchTreat.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
//Repository-> class object + peak the data from database
namespace DutchTreat.Controllers
{
  public class AppController : Controller
  {
    private readonly IDutchRepository _repository;

    public AppController(IDutchRepository repository)
    {
      _repository = repository;
    }

    public IActionResult Index()
    {
        return View();
    }
    [Authorize]
    public IActionResult SurveyResults()
    {
        var results = _repository.GetHomePageQuestions();

        return View(results);
    }

    public IActionResult About()
    {
      return View();
    }

        public IActionResult SurveyComplete()
        {
            return View();
        }
        public IActionResult Question()
    {
      var results = _repository.GetAllQuestions().ToList();

      return View(results);
    }

    [Authorize]
    //Add question get action(Method) 
    //Question list -> Database -> controller -> render
    public IActionResult StudentList()
    {
        var results = _repository.getStudentList();//all the question will add in result
        return View(results);
    }

    [Authorize]
    public IActionResult SurveyDetails(int Id)
    {
        var feedbackViews = _repository.getStudentFeedback(Id);

        return View(feedbackViews);
    }

    [Authorize]
    //Add question get action(Method) 
    //Question list -> Database -> controller -> render
    public IActionResult QuestionList()
    {
        var results = _repository.GetAllQuestions();//all the question will add in result
        return View(results);
    }
    [Authorize]
    //Add question get action(Method)-> its works two action
    public IActionResult AddQuestion()//add question view method
    {
        return View();
    }
    [Authorize]
    [HttpPost]
    public IActionResult AddQuestion(Question model)//submitted+is it show in home page?
    {
        if (ModelState.IsValid)
        {
            _repository.AddEntity(model);//add question in database
            _repository.SaveAll();
            ModelState.Clear();
        }

        return RedirectToAction("QuestionList");
    }
    [Authorize]
    public IActionResult EditQuestion(int Id)
    {
        var question = _repository.GetAllQuestions().Where(s => s.Id == Id).FirstOrDefault();

        return View(question);
    }

    [Authorize]
    [HttpPost]
    public ActionResult EditQuestion(Question model)
    {

        if (ModelState.IsValid)
        {
            _repository.UpdateEntity(model);//Entity framework update database,
            _repository.SaveAll();//Entity framework save database,
                ModelState.Clear();
        }

        return RedirectToAction("QuestionList");
    }

    [HttpPost]
    public ActionResult DeleteQuestion(int Id)
    {
        Question question = _repository.GetAllQuestions().Where(s => s.Id == Id).FirstOrDefault();
        _repository.DeleteEntity(question);
        _repository.SaveAll();
        return RedirectToAction("QuestionList");
    }


    public IActionResult Registration()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Registration(Student model)
    {
      if (ModelState.IsValid)
      {
        if(_repository.CheckExistingStudent(model.UniversityId,model.Email)) return RedirectToAction("RegistrationFailure", "App"); ;
        _repository.AddEntity(model);
        _repository.SaveAll();
        ModelState.Clear();
      }

      return RedirectToAction("Question", "App", new { id = model.Id });
    }

    [HttpGet]
    public IActionResult RegistrationFailure()
    {
      return View();
    }
  }
}
