using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Ecommerce.Controllers
{
    public class GizlilikController : Controller
    {
        // GET: Gizlilik
        [Route("gizlilik")]
        public ActionResult Gizlilik()
        {
            return View();
        }
    }
}