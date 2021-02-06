using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Ecommerce.Controllers
{
    public class CookieController : Controller
    {
        // GET: Cookie
        [Route("cookie")]
        public ActionResult Cookie()
        {
            return View();
        }
    }
}