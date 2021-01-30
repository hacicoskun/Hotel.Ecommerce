using Hotel_Ecommerce.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Ecommerce.Areas.Admin.Model
{
    public class OtelEklemeveGuncelleme
    {
        public List<OdaOzellikListesi> OdaOzellikleri { get; set; }
        public List<OtelOzellikListesi> OtelOzellikleri { get; set; }
        public List<OtelTemalariListesi> OtelTemalariListesi { get; set; }
        public HotelEdit Data { get; set; }

        public class HotelEdit
        {
            public List<OdaOzellikleri> SeciliOdaOzellikleri { get; set; } = new List<OdaOzellikleri>();
            public List<OtelOzellikleri> SeciliOtelOzellikleri { get; set; } = new List<OtelOzellikleri>();
            public List<OtelTemalari> SeciliOtelTemalariListesi { get; set; } = new List<OtelTemalari>();
            public Oteller Otel { get; set; }
        }
    }

}