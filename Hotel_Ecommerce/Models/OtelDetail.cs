using Hotel_Ecommerce.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Ecommerce.Models
{
    public class OtelDetail
    {
        public Oteller Otel { get; set; }
        public List<OtelOzellikleri> OtelOzellikleri { get; set; }
        public List<OdaOzellikleri> OdaOzellikleri { get; set; }
        public string iframeMap { get; set; }
    }
}