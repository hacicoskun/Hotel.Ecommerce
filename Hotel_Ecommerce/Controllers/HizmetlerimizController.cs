using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Ecommerce.Controllers
{
    public class HizmetlerimizController : Controller
    {
        // GET: Hizmetlerimiz
        [Route("hizmetlerimiz")]
        public ActionResult Hizmetlerimiz()
        {
            return View();
        }
    }
}