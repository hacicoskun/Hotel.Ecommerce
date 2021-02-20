using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Ecommerce.Controllers
{
    public class BecomingTeknikController : Controller
    {
        // GET: BecomingTeknik
        [Route("becoming-teknik")]
        public ActionResult BecomingTeknik()
        {
            return View();
        }
    }
}