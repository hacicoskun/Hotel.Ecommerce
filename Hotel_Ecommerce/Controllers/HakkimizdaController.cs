using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Ecommerce.Controllers
{
    public class HakkimizdaController : Controller
    {
        // GET: Hakkimizda
        [Route("hakkimizda")]
        public ActionResult Hakkimizda()
        {
            return View();
        }
    }
}