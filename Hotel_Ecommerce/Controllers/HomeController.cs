using Hotel_Ecommerce.Models;
using Hotel_Ecommerce.Utils;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Ecommerce.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Home
        [Route("")]
        public ActionResult Index()
        {
            Homepage homepage = new Homepage();
            homepage.OncelikliOteller = _unitOfWork.Oteller.Where(x => x.OtelOncelik).Take(8).Select(s => new OncelikliOteller
            {
                Adi = s.OtelAdi,
                KisaAciklama = s.OtelKisaBilgi.Length >= 100 ? s.OtelKisaBilgi.Substring(0, 99)+".." : s.OtelKisaBilgi,
                Konumu = s.Otelil + "," + s.Otelilce + "," + s.OtelBolgesi,
                KonaklamaTipi = s.KonaklamaTipi,
                Link=s.OtelLink,
                Resim=s.OtelAnasayfaResmi
            }).ToList();
            return View(homepage);
        }


    }
}