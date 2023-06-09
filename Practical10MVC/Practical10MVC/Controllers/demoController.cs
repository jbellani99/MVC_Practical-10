using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical10MVC.Controllers
{
    public class demoController : Controller
    {
        // GET: Script
        [HttpGet]
        public ActionResult Index()
        {
           var msg ="<Script>alert('Have a great day!');</script>";
            
            return  Content(msg);
        }
    }
}