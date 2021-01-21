using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Hotel_Ecommerce.Areas.Admin.Controllers
{
    [RouteArea("Admin", AreaPrefix = "panel")]
    public class AdminLoginController : BaseController
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
            
           

           

        }
    }
}