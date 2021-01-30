using Hotel_Ecoomerce.DAL.Concrete;
using Newtonsoft.Json;
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
        
            
            if (Baslik.Trim()!="" && İcerik.Trim()!="" && !_unitOfWork.TurMenusu.Any(x => x.Baslik == Baslik))
            {            
                    TurMenusu turmenusu = new TurMenusu
                    {
                        Baslik = Baslik,
                        İcerik = İcerik,
                        CreatedDate = DateTime.Now,
                        IsDeleted = false,
                        IsActive = true,

                    };
                    _unitOfWork.TurMenusu.Insert(turmenusu);
                    _unitOfWork.Save();
                    deger = "1";
                    return Json(deger);
                
            }
            else if (_unitOfWork.TurMenusu.Any(x=>x.Baslik==Baslik))
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
        [ValidateInput(false)]
        public ActionResult GetTurMenu(string Baslik)
        {         
            var Liste = _unitOfWork.TurMenusu.ToList();
            var İcerik = Liste.Find(x => x.Baslik == Baslik);
            var deger = İcerik.İcerik;
            return Json(İcerik);
            //return Content(JsonConvert.SerializeObject(deger), "application/json");

        }
        [Route("get-tur-menusu-icerik")]
        [ValidateInput(false)]
        public ActionResult UpdateTurMenu(string Baslik,string İcerik)
        {
            var deger = "0";

            if (_unitOfWork.TurMenusu.Any(x=>x.Baslik.ToLower()==Baslik.ToLower()))
            {
                TurMenusu turmenusu = _unitOfWork.TurMenusu.Find(x => x.Baslik == Baslik);
                turmenusu.CreatedDate = DateTime.Now;
                turmenusu.Baslik = Baslik;
                turmenusu.İcerik = İcerik;
                _unitOfWork.TurMenusu.Update(turmenusu);
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