using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Ecommerce.Areas.Admin.Controllers
{
    [RouteArea("Admin", AreaPrefix = "panel")]

    public class CreateHotelController : Controller
    {
        [Route("create-hotel")]

        public ActionResult CreateHotel()
        {
            return View();
        }
    }
}