using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult CreateQuiz()
        {
            var quiz = new Quiz();
            quiz.NewQuestion = new Question();
            quiz.NewQuestion.Answers = new List<Answer>();
            quiz.Questions = new List<Question>();
            return View(quiz);
        }

        [HttpPost]
        public ActionResult CreateQuiz(Quiz model)
        {
            if (string.IsNullOrEmpty(model.QuizName))
            {
                ModelState.AddModelError("QuizName", "Please enter a quiz name.");
            }

            if (model.Questions.Count == 0)
            {
                ModelState.AddModelError("", "Please add at least one question.");
            }

            foreach (var question in model.Questions)
            {
                if (string.IsNullOrEmpty(question.Text))
                {
                    ModelState.AddModelError("", $"Please enter text for question {question.QuestionNumber}.");
                }

                if (question.Answers.Count == 0)
                {
                    ModelState.AddModelError("", $"Please enter at least one answer for question {question.QuestionNumber}.");
                }
            }

            if (!ModelState.IsValid)
            {
                return View(model);
            }


            return RedirectToAction("QuizCreated");
        }

        public ActionResult QuizCreated()
        {
            return View();
        }

        public ActionResult QuizList()
        {
            return View();
        }
    }
}
