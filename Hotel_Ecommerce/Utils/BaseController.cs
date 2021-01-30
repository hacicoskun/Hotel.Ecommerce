using Hotel_Ecommerce.DAL.Concrete;
using MevsimTazesi.Repository.UnitOfWork;
using System.Linq;
using System.Web.Mvc;

namespace Hotel_Ecommerce.Utils
{
    public class BaseController : Controller
    {
        // GET: Base
        public UnitOfWork _unitOfWork = new UnitOfWork();
        public LoginUsers user = new LoginUsers();
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {

       

           

            base.OnActionExecuting(filterContext);
        }
    }
}