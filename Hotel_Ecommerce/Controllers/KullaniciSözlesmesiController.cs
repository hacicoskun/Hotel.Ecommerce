using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Ecommerce.Controllers
{
    public class KullaniciSözlesmesiController : Controller
    {
        // GET: KullaniciSözlesmesi
        [Route("kullanici-sozlesmesi")]
        public ActionResult KullaniciSözlesmesi()
        {
            return View();
        }
    }
}