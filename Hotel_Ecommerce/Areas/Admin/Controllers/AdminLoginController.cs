using Hotel_Ecommerce.Helper.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;


namespace Hotel_Ecommerce.Areas.Admin.Controllers
{
    [RouteArea("Admin", AreaPrefix = "panel")]
    public class AdminLoginController : AdminBaseController
    {
        [Route("login")]
        // GET: Admin/AdminLogin
        public ActionResult Index()
        {
            return View();
        }
        [Route("user-login")]
        public ActionResult LoginControl(string Username, string Password)
        {
            string password = Password.ToMD5Hash();
            if (_unitOfWork.LoginUsers.Any(x => x.KullaniciAdi == Username && x.Sifre == Password))
            {
                Session.Add("AdminUserID", _unitOfWork.LoginUsers.Find(x => x.KullaniciAdi == Username && x.Sifre == Password)._id);
                Session.Add("AdminUserNameLastName", _unitOfWork.LoginUsers.Find(x => x.KullaniciAdi == Username && x.Sifre == Password));
                return Json(HttpStatusCode.OK);
            }

            return Json(HttpStatusCode.InternalServerError);

        }

        
    }
}