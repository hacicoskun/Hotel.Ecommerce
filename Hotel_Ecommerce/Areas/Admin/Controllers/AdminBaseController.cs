using Hotel_Ecoomerce.DAL.Concrete;
using MevsimTazesi.Repository.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Ecommerce.Areas.Admin.Controllers
{
    public class AdminBaseController : Controller
    {
        public UnitOfWork _unitOfWork;
        public LoginUsers _sessionUser;

        public AdminBaseController()
        {
            _unitOfWork = new UnitOfWork();
            //try
            //{
            //    string sessionUserId = System.Web.HttpContext.Current.Session["AdminUserID"] as string;

            //    if (string.IsNullOrEmpty(sessionUserId))
            //    {
            //        throw new HttpException(404, "Not found");

            //    }
            //    else
            //    {
            //        _unitOfWork = new UnitOfWork();
            //    }

            //}
            //catch (Exception)
            //{
            //    throw new HttpException(404, "Not found");

            //}
        }
    }
}