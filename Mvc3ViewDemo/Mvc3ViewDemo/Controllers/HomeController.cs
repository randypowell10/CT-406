using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mvc3ViewDemo.Models;

namespace Mvc3ViewDemo.Controllers
{
    public class Blog
    {
        public string Name;
        public string URL;
    }

    public class HomeController : Controller
    {
        List<Blog> topBlogs = new List<Blog>
      {
          new Blog { Name = "ScottGu", URL = "http://weblogs.asp.net/scottgu/"},
          new Blog { Name = "Scott Hanselman", URL = "http://www.hanselman.com/blog/"},
          new Blog { Name = "Jon Galloway", URL = "http://www.asp.net/mvc"}
      };
        public IActionResult Index()
        {
            return View(topBlogs);
        }
        public ActionResult IndexNotStronglyTyped() {

            return View(topBlogs);
        }

        public ActionResult StronglyTypedIndex()
        {
            return View(topBlogs);
        }

        //public IActionResult About()
        //{
        //    ViewData["Message"] = "ASP.NET MVC! Welcome!";

        //    return View();
        //}

        //public IActionResult Contact()
        //{
        //    ViewData["Message"] = "Your contact page.";

        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
