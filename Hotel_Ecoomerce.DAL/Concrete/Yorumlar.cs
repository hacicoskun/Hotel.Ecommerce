using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Ecommerce.DAL.Concrete
{
    [Table("Yorumlar")]
    public class Yorumlar : BaseEntity
    {
        public string OtelID { get; set; }
        public string OtelAdi { get; set; }
        public string YorumAtanKisi { get; set; }
        public string YorumBaslik { get; set; }
        public string YorumTelefon { get; set; }
        public string YorumDetay { get; set; }
        public string YorumTarihi { get; set; }
        public string YorunIpAdress { get; set; }
        public bool YorumAktifMi { get; set; }
        public int YorumPuan1 { get; set; }
        public int YorumPuan2 { get; set; }
        public int YorumPuan3 { get; set; }
        public string YorumEmail { get; set; }
    }
}
