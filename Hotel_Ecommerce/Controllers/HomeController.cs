using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Ecommerce.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }

        
    }
}