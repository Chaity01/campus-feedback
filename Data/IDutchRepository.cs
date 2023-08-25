using System.Collections.Generic;
using CampusFeedback.ViewModels;
using DutchTreat.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DutchTreat.Data
{
  public interface IDutchRepository
  {
    IEnumerable<Question> GetAllQuestions();
    IEnumerable<Question> GetHomePageQuestions();
    IEnumerable<Feedback> GetFeedbackofQuestion(int questionId);
    int GetNumberOfStudents();
    bool CheckExistingStudent(string universityId, string email);
    Student getStudentInfo(int id);
    List<Student> getStudentList();
    List<FeedbackView> getStudentFeedback(int studentId);
    void AddEntity(object entity);
    bool SaveAll();
    void UpdateEntity(Question question);
    void DeleteEntity(object entity);
  }
}