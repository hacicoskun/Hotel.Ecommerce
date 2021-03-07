using Hotel_Ecommerce.Areas.Admin.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Ecommerce.Controllers
{
    public class SayfalarMenusuController : AdminBaseController
    {
        // GET: GetTurMenu
        [Route("yurticiturlar")]
        public ActionResult YurtIciGetTurMenu()
        {
            var values = _unitOfWork.SayfalarMenusu.Find(x => x.Baslik == "YurticiTurları");
            ViewBag.valueIci = values.İcerik;
            return View();
        }
        [Route("yurtdisiturlar")]
        public ActionResult YurtDisiGetTurMenu()
        {
            var values = _unitOfWork.SayfalarMenusu.Find(x => x.Baslik == "YurtdisiTurları");
            ViewBag.valueDisi = values.İcerik;
            return View();
        }
        [Route("bilet")]
        public ActionResult BiletGetTurMenu()
        {
            var values = _unitOfWork.SayfalarMenusu.Find(x => x.Baslik == "Bilet");
            ViewBag.valueBilet = values.İcerik;
            return View();
        }
        [Route("vize")]
        public ActionResult VizeGetTurMenu()
        {
            var values = _unitOfWork.SayfalarMenusu.Find(x => x.Baslik == "Vize");
            ViewBag.valueVize = values.İcerik;
            return View();
        }
        [Route("mice")]
        public ActionResult MiceGetTurMenu()
        {
            var values = _unitOfWork.SayfalarMenusu.Find(x => x.Baslik == "Mice");
            ViewBag.valueMice = values.İcerik;
            return View();
        } 
        [Route("hizmetlerimiz")]
        public ActionResult HizmetlerimizGetTurMenu()
        {
            var values = _unitOfWork.SayfalarMenusu.Find(x => x.Baslik == "Hizmetlerimiz");
            ViewBag.valueHizmetlerimiz = values.İcerik;
            return View();
        }
        [Route("transfer")]
        public ActionResult TransferGetTurMenu()
        {
            var values = _unitOfWork.SayfalarMenusu.Find(x => x.Baslik == "Transfer");
            ViewBag.valueTransfer = values.İcerik;
            return View();
        }
        [Route("cruise")]
        public ActionResult CruiseGetTurMenu()
        {
            var values = _unitOfWork.SayfalarMenusu.Find(x => x.Baslik == "Cruise");
            ViewBag.valueCruise = values.İcerik;
            return View();
        }
        [Route("ozelyat-kiralama")]
        public ActionResult OzelYatGetTurMenu()
        {
            var values = _unitOfWork.SayfalarMenusu.Find(x => x.Baslik == "OzelYatKiralama");
            ViewBag.valueOzelYat = values.İcerik;
            return View();
        }
        [Route("ozelvilla-kiralama")]
        public ActionResult OzelVillaGetTurMenu()
        {
            var values = _unitOfWork.SayfalarMenusu.Find(x => x.Baslik == "OzelVillaKiralama");
            ViewBag.valueOzelVilla = values.İcerik;
            return View();
        }

    }
}