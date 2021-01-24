using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Ecommerce.DAL.Concrete
{
    [Table("BiziTakipEdin")] 
    public class BiziTakipEdin : BaseEntity
    {
        public string Adsoyad { get; set; }
        public string Email { get; set; }
        public string Ipadresi { get; set; }
        public DateTime IslemTarihi { get; set; }
    }
}
