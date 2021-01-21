using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Ecoomerce.DAL.Concrete
{
    [Table("Iletisim")]

    public class Iletisim : BaseEntity
    {
        public string Adsoyad { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Departman { get; set; }
        public string Baslik { get; set; }
        public string Mesaj { get; set; }
        public string Ipadresi { get; set; }
    }
}
