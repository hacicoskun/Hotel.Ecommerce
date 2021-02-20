using Hotel_Ecommerce.Models;
using Hotel_Ecommerce.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_Ecommerce.Controllers
{
    public class DetailController : BaseController
    {
        // GET: Detail

        [Route("{OtelBolgesi}/{OtelKonum}/{OtelAdi}")]
        public ActionResult Detail()
        {
            string link = RouteData.Values["OtelBolgesi"].ToString() + "/" + RouteData.Values["OtelKonum"].ToString() + "/" + RouteData.Values["OtelAdi"].ToString();
            var otel = _unitOfWork.Oteller.FirstOrDefault(x => x.OtelLink == link);
            string iframelink = "https://maps.google.com/maps?q=" + otel.OtelXYKoordinat + "&hl=es;z=14&amp;output=embed";
     
            OtelDetail otelDetail = new OtelDetail
            {
                Otel = otel,
                OtelOzellikleri = _unitOfWork.OtelOzellikleri.Where(x => x.OtelSubID == otel._id).ToList(),
                OdaOzellikleri = _unitOfWork.OdaOzellikleri.Where(x => x.OtelSubID == otel._id).ToList(),
                iframeMap=iframelink
            };

            return View(otelDetail);
        }
    }
}