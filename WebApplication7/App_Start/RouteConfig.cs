using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication7
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "CreateQuiz",
                url: "Home/CreateQuiz",
                defaults: new { controller = "Home", action = "CreateQuiz" }
            );
            routes.MapRoute(
                name: "QuizList",
                url: "quiz/list",
                defaults: new { controller = "Quiz", action = "QuizList" }
            );

        }
    }
}
