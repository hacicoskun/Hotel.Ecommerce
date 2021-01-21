using Hotel_Ecommerce.Areas.Admin.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Ecommerce.Areas.Admin.Controllers
{
    [RouteArea("Admin", AreaPrefix = "panel")]

    public class CreateHotelController : AdminBaseController
    {
        [Route("create-hotel")]

        public ActionResult CreateHotel()
        {
            OtelEklemeveGuncelleme OtelEklemeveGuncelleme = new OtelEklemeveGuncelleme
            {
                OdaOzellikleri = _unitOfWork.OdaOzellikTablosu.ToList(),
                OtelOzellikleri = _unitOfWork.OtelOzellikTablosu.ToList()
            };
            return View(OtelEklemeveGuncelleme);
        }
    }
}