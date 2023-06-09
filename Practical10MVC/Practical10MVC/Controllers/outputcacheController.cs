using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Practical10MVC.Controllers
{
    public class outputcacheController : Controller
    {
        // GET: outputcache
        [OutputCache (Duration =300)]
        public string Index()
        {
           

            string dt = DateTime.Now.ToString();
           

            return dt;
        }
    }
}