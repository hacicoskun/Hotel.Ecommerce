using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Ecommerce.DAL.Concrete
{
    [Table("OtelTeklifleri")]
    public class OtelTeklifleri:BaseEntity
    {
        public string OtelAdi { get; set; }
        public string Adsoyad { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string YetiskinSayisi { get; set; }
        public string CocukSayisi { get; set; }
        public string Cocuk1Yas { get; set; }
        public string Cocuk2Yas { get; set; }
        public string Ipadresi { get; set; }
        public string RezTarihi { get; set; }
        public DateTime IslemTarihi { get; set; }
    }
}
