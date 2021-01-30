using Hotel_Ecoomerce.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Ecommerce.Areas.Admin.Controllers
{
    [RouteArea("Admin", AreaPrefix = "panel")]
    public class MenuController : AdminBaseController
    {
        // GET: Admin/Menu
        [Route("menu")]
        public ActionResult Menu()
        {
            return View();
        }
        [Route("create-turmenusu")]
        public ActionResult CreateTurMenu(string Baslik,string İcerik)
        {
            if (Baslik.Length>0 && İcerik.Length>0)
            {
                TurMenusu turmenusu = new TurMenusu
                {
                    Baslik = Baslik,
                    İcerik = İcerik,
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                    IsActive = true,
                    UserID = _sessionUser._id
                };
                _unitOfWork.TurMenusu.Insert(turmenusu);
                _unitOfWork.Save();
                return Json(true);
            }
            else
            {
                return Json(false);
            }
            
        }
    }
}