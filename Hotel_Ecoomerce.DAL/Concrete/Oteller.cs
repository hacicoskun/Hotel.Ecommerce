using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Ecommerce.DAL.Concrete
{
    [Table("Oteller")]
    public class Oteller:BaseEntity
    {
        public string OtelAdi { get; set; }
        public string OtelKisaBilgi { get; set; }
        public string OtelBolgesi { get; set; }
        public string Otelil { get; set; }
        public string Otelilce { get; set; }
        public string OtelXYKoordinat { get; set; }
        public string KonaklamaTipi { get; set; }
        public string OtelDivBilgi { get; set; }
        public string OtelAciklama { get; set; }
        public int OtelGoruntulenmeSayisi { get; set; }
        public string OtelDosyaLink { get; set; }
        public string OtelAnasayfaResmi { get; set; }
        public string OtelGaleriKlasor { get; set; }
        public System.DateTime OtelEklenmeTarihi { get; set; }
        public bool OtelAktifMi { get; set; }
        public int OtelPuan { get; set; }
        public bool OtelOncelik { get; set; }
        public string OtelLink { get; set; }
        public string OtelSezonu { get; set; }
        public string OdaAciklama { get; set; }
        public bool SehirOteli { get; set; }
    }
}
