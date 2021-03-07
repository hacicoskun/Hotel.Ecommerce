using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Ecommerce.Controllers
{
    public class MICEController : Controller
    {
        // GET: MICE
        [Route("old-MICE")]
        public ActionResult MICE()
        {
            return View();
        }
    }
}