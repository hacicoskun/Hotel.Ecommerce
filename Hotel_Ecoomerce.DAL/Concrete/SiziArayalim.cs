using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Ecommerce.DAL.Concrete
{
    [Table("SiziArayalim")]
    public class SiziArayalim:BaseEntity
    {

        public string Adsoyad { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Konu { get; set; }
        public string Aramatarihi { get; set; }
        public string Aramazamani { get; set; }
        public string Ipadresi { get; set; }
        public DateTime Islemtarihi { get; set; }
    }
}
