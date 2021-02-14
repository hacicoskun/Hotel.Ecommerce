using Hotel_Ecommerce.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Ecommerce.Models
{
    public class FiltreOtel
    {
        public FiltreCheckbox Checkboxs { get; set; }
        public List<Oteller> Otels { get; set; }
        public string Bolge { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
    }
    public class FiltreCheckbox
    {
        public List<FiltreKonaklamaTipleri> KonaklamaTipleri { get; set; }
        public List<FiltreOtelOzellikleri> OtelOzellikleri { get; set; }
    }
    // GET: Filter
    public class FiltreKonaklamaTipleri
    {
        public string KonaklamaAdi { get; set; }
        public string KonaklamaAdiValue { get; set; }
    }
    public class FiltreOtelOzellikleri
    {
        public string OlanakAdi { get; set; }
        public int KacOteldeVar { get; set; }
        public string OlanakveSayisi { get; set; }
    }

}