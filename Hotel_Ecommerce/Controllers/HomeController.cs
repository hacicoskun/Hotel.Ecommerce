using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Ecommerce.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [Route("test")]
        public ActionResult Index()
        {
            return View();
        }
    }
}