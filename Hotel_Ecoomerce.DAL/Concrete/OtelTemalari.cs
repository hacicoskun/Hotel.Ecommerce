using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Ecommerce.DAL.Concrete
{
    [Table("OtelTemalari")]

    public class OtelTemalari : BaseEntity
    {
        public string OtelSubID { get; set; }
        public string OtelTemaAdi { get; set; }
    }
}
