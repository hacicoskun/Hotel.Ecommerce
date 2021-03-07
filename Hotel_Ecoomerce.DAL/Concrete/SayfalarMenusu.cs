using Hotel_Ecommerce.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Ecommerce.DAL.Concrete
{
    [Table("SayfalarMenusu")]
    public class SayfalarMenusu : BaseEntity
    {
        public string Baslik { get; set; }
        public string İcerik { get; set; }
    }
}
