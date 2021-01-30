using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hotel_Ecommerce.Models
{
    public class Homepage
    {
        public List<OncelikliOteller> OncelikliOteller { get; set; }
    }

    public class OncelikliOteller
    {
        public string Adi { get; set; }
        public string Resim { get; set; }
        public string Link { get; set; }

        public string KisaAciklama { get; set; }
        public string Konumu { get; set; }
        public string KonaklamaTipi { get; set; }

    }
}