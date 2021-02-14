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
            List<JsonData> Otelİl = _unitOfWork.Oteller.Where(x => x.OtelAktifMi == true && !x.IsDeleted).Select(s => new JsonData
            {
                FilterType = 0,
                Name = s.OtelAdi,
                Link = "/" + s.OtelLink,
                Adress = s.OtelBolgesi!="Kıbrıs Otelleri" ? s.Otelil + " Otelleri,Türkiye": s.Otelil + " Otelleri,Kıbrıs",
                Location = s.OtelBolgesi,
                OtelMi = "0"
            }).ToList();
            List<JsonData> Otelİlce = _unitOfWork.Oteller.Where(x => x.OtelAktifMi == true && !x.IsDeleted).Select(s => new JsonData
            {
                FilterType = 0,
                Name = s.OtelAdi,
                Link = "/" + s.OtelLink,
                Adress = s.OtelBolgesi != "Kıbrıs Otelleri" ? s.Otelil +","+s.Otelilce.Split('-')[0]+ " Otelleri,Türkiye" : s.Otelil +","+ s.Otelilce.Split(',')[0]+ "  Otelleri,Kıbrıs",
                Location = s.OtelBolgesi,
                OtelMi = "0"
            }).ToList();


            List<JsonData> Oteller = _unitOfWork.Oteller.Where(x => x.OtelAktifMi == true && !x.IsDeleted).Select(s => new JsonData
            {
                FilterType = 0,
                Name = s.OtelAdi,
                Link = "/" + s.OtelLink,
                Adress = s.Otelil + "," + s.Otelilce,
                Location = s.OtelBolgesi,
                OtelMi = "1"
            }).ToList();
            Oteller.AddRange(Otelİl.GroupBy(p => p.Adress).Select(g => g.First()).ToList());
            Oteller.AddRange(Otelİlce.GroupBy(p => p.Adress).Select(g => g.First()).ToList());

            Oteller = Oteller.OrderBy(x => x.OtelMi=="1").ToList();
            return this.Json(Oteller, JsonRequestBehavior.AllowGet);

        }
        public class JsonData
        {
            public string Name { get; set; }
            public string Link { get; set; }
            public int FilterType { get; set; }
            public string Location { get; set; }

            public string Adress { get; set; }
            public string OtelMi { get; set; }
        }
    }
}