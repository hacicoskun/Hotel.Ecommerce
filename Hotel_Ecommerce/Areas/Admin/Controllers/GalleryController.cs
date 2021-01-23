using System.Net;
using System.Web.Mvc;

namespace Hotel_Ecommerce.Areas.Admin.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Admin/Gallery
        public ActionResult Gallery()
        {
            ViewBag.user_id = "123";
            ViewBag.fileRoot = "\"/Uploads/\"";
            ViewBag.serverRoot = "true";
            ViewBag.serverMode = "false";
            ViewBag.useFileTable = "false";
            return View();
        }

        [Route("create-gallery-session")]
        public ActionResult CreateGallerySession(string sessionID, string sliderFolder, string screenImage)
        {
            Session.Add("gallery_SliderPath_" + sessionID, sliderFolder);
            Session.Add("gallery_ScreenImage_" + sessionID, sliderFolder + screenImage);

            return Json(HttpStatusCode.OK);
        }
    }
}