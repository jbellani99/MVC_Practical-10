using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical10MVC.Controllers
{
    [HandleError(ExceptionType = typeof(DivideByZeroException), View ="excep")]
    public class dividebyzeroController : Controller
    {
        // GET: dividebyzero
        public ActionResult Index()
        {
            
                throw new DivideByZeroException();

            
        }
    }
}