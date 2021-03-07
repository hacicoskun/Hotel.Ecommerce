using Hotel_Ecommerce.Areas.Admin.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Ecommerce.Controllers
{
    public class TurMenuController : AdminBaseController
    {
        // GET: GetTurMenu
        [Route("yurtici-turlar")]
        public ActionResult YurtIciGetTurMenu()
        {
            var values = _unitOfWork.TurMenusu.Find(x => x.Baslik == "YurticiTurları");
            ViewBag.valueIci = values.İcerik;
            return View();
        }
        [Route("yurtdisi-turlar")]
        public ActionResult YurtDisiGetTurMenu()
        {
            var values = _unitOfWork.TurMenusu.Find(x => x.Baslik == "YurtdisiTurları");
            ViewBag.valueDisi = values.İcerik;
            return View();
        }
    }
}