using Hotel_Ecoomerce.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Ecommerce.Areas.Admin.Model
{
    public class OtelEklemeveGuncelleme
    {
        public List<OdaOzellikTablosu> OdaOzellikleri { get; set; }
        public List<OtelOzellikTablosu> OtelOzellikleri { get; set; }

    }
}