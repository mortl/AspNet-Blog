using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using AspBlog.Model;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AspBlog.Controllers
{
    public class HomeController : Controller
    {
        public string _author = "Martin Benes";
        // GET: /<controller>/
        public IActionResult Index()
        {
            var posts = new[] {
                new Post
                {
                    Title = "Blog Post 1",
                    PostedDate = DateTime.Now,
                    Author = _author,
                    Body = "This is the first post on this MVC ASP 6 blog!",
                },
                new Post
                {
                    Title = "Blog Post 2",
                    PostedDate = DateTime.Now,
                    Author = _author,
                    Body = "This is a second post",
                },
                new Post
                {
                    Title = "Heavy Metal is the law",
                    PostedDate = DateTime.Now,
                    Author = _author + "The Viking!",
                    Body = "If you don't listen to metal, then you must die!",
                },
            };
           return View(posts);
        }

    
        public string Echo(string id)
        {
            return id;

        }
    }
}
