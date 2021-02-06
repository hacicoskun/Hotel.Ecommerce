using Hotel_Ecommerce.DAL.Concrete;
using Hotel_Ecommerce.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Ecommerce.Controllers.Services
{
    public class SearchAutoCompleteController : BaseController
    {
        // GET: SearchAutoComplete
        [Route("aramasonuclari")]
        public ActionResult Index()
        {
            List<JsonData> Oteller = _unitOfWork.Oteller.Where(x => x.OtelAktifMi == true && !x.IsDeleted).Select(s => new JsonData
            {
                FilterType = 0,
                Name = s.OtelAdi,
                Link = "http://www.becomingtur.com/" + s.OtelLink,
                Adress = s.Otelil + "," + s.Otelilce,
                Location=s.OtelBolgesi
            }).ToList();
            return this.Json(Oteller, JsonRequestBehavior.AllowGet);

        }
        public class JsonData
        {
            public string Name { get; set; }
            public string Link { get; set; }
            public int FilterType { get; set; } 
            public string Location { get; set; }

            public string Adress { get; set; }
        }
    }
}