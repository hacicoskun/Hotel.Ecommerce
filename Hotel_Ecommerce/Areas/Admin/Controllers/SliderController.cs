using Hotel_Ecommerce.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Ecommerce.Areas.Admin.Controllers
{
    [RouteArea("Admin",AreaPrefix ="panel")]
    public class SliderController : AdminBaseController
    {
        [Route("slider-list")]
        // GET: Admin/Slider
        public ActionResult SliderManagement()
        {
            var images = _unitOfWork.AnasayfaSlider.ToList().OrderBy(x => x.Düzen).ToList();
            return View(images);
        }
        [Route("upload-slider-image")]
        public JsonResult UploadImage(HttpPostedFileBase file)
        {
            if (file!=null && file.ContentLength>0)
            {
                DateTime baslangicTarihi = Convert.ToDateTime(Request.Form["baslangicTarihi"].ToString());
                DateTime bitisTarihi = Convert.ToDateTime(Request.Form["bitisTarihi"].ToString());
                string link = Request.Form["link"].ToString();
                string tip = Request.Form["tip"].ToString();
                string hedef = Request.Form["hedef"].ToString();
                string dosyaAdi = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                var path = Path.Combine(Server.MapPath("~/Areas/Files/slider"), dosyaAdi);
                file.SaveAs(path);
                var maxOrder = _unitOfWork.AnasayfaSlider.ToList().OrderBy(x => x.Düzen).LastOrDefault();
                var image = new AnasayfaSlider();
                image.Isım = dosyaAdi;
                image.Düzen = maxOrder == null ? 1 : maxOrder.Düzen++;
                image.CreatedDate = DateTime.Now;
                image.IsActive = true;
                image.IsDeleted = false;
                //image.UserID = Session["AdminUserID"].ToString();
                image.Link = link;
                image.Hedef = hedef;
                image.Tip = tip;
                image.SliderBaslangicTarihi = baslangicTarihi;
                image.SliderBitisTarihi = bitisTarihi;

                _unitOfWork.AnasayfaSlider.Insert(image);
                _unitOfWork.Save();
                return Json(image);

            }
            else
            {
                return Json("");
            }
        }

        [Route("update-slider-order")]
        public JsonResult OrderSlides(string[] list)
        {
            var imagelist = _unitOfWork.AnasayfaSlider.ToList();

            foreach (var item in list)
            {
                var order = item.Split(':');
                var image = imagelist.FirstOrDefault(x => x._id == order[0]);
                if (image != null)
                    image.Düzen = Convert.ToInt32(order[1]);
            }

            _unitOfWork.Save();
            return Json("");
        }


        [Route("delete-slider-image")]
        public JsonResult DeleteImage(string ImageID)
        {
            if (_unitOfWork.AnasayfaSlider.Any(x => x._id == ImageID))
            {
                var slideImage = _unitOfWork.AnasayfaSlider.FirstOrDefault(x => x._id == ImageID);
                _unitOfWork.AnasayfaSlider.Delete(slideImage);
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