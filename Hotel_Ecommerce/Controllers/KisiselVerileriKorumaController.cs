using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Ecommerce.Controllers
{
    public class KisiselVerileriKorumaController : Controller
    {
        // GET: KisiselVerileriKoruma
        [Route("kisisel-verileri-koruma")]
        public ActionResult KisiselVerileriKoruma()
        {
            return View();
        }
    }
}