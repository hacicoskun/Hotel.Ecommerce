﻿using Hotel_Ecommerce.DAL.Concrete;
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

    }
}