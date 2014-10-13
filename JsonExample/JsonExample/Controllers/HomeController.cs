using JsonExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JsonExample.Controllers
{
    public class HomeController : Controller
    {
        public List<Product> products = new List<Product>{ 
            new Product{ Id = 1, Name = "Computer", Description="Use to make programms"}, 
            new Product{Id = 2, Name = "Xbox", Description="Use to play games"}};

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetByJson()
        {
            List<int> myList = new List<int> { 5, 6, 7, 8, 9, 10 };
            return Json(myList, JsonRequestBehavior.AllowGet);
        }
    }
}
