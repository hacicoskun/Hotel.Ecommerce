using Hotel_Ecommerce.DAL.Concrete;
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

        [Route("create-tur-menusu-icerik")]
        [ValidateInput(false)]
        public ActionResult CreateTurMenu(string Baslik,string İcerik)
        {
            var deger = "0";
        
            
            if (Baslik.Trim()!="" && İcerik.Trim()!="" && !_unitOfWork.SayfalarMenusu.Any(x => x.Baslik == Baslik))
            {
                SayfalarMenusu turmenusu = new SayfalarMenusu
                {
                        Baslik = Baslik,
                        İcerik = İcerik,
                        CreatedDate = DateTime.Now,
                        IsDeleted = false,
                        IsActive = true,

                    };
                    _unitOfWork.SayfalarMenusu.Insert(turmenusu);
                    _unitOfWork.Save();
                    deger = "1";
                    return Json(deger);
                
            }
            else if (_unitOfWork.SayfalarMenusu.Any(x=>x.Baslik==Baslik))
            {
                UpdateTurMenu(Baslik, İcerik);
                deger = "1";
                return Json(deger);

            }
            else
            {
                return Json(deger);
            }
            
        }

        [Route("get-tur-menusu-icerik")]
        public ActionResult GetTurMenu(string Baslik)
          {
            var deger = _unitOfWork.SayfalarMenusu.FirstOrDefault(x => x.Baslik.ToLower() == Baslik.ToLower()).İcerik;
            return Json(deger);

        }
        [Route("update-tur-menusu-icerik")]
        [ValidateInput(false)]
        public ActionResult UpdateTurMenu(string Baslik,string İcerik)
        {
            var deger = "0";

            if (_unitOfWork.SayfalarMenusu.Any(x=>x.Baslik.ToLower()==Baslik.ToLower()))
            {
                SayfalarMenusu turmenusu = _unitOfWork.SayfalarMenusu.Find(x => x.Baslik == Baslik);
                turmenusu.CreatedDate = DateTime.Now;
                turmenusu.Baslik = Baslik;
                turmenusu.İcerik = İcerik;
                _unitOfWork.SayfalarMenusu.Update(turmenusu);
                _unitOfWork.Save();
                deger = "1";
                return Json(deger);
            }
            else
            {
                return Json(deger);
            }
           

        }

        

    }
}