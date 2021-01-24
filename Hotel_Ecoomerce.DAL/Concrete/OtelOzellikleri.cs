using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Ecommerce.DAL.Concrete
{
    [Table("OtelOzellikleri")]

    public class OtelOzellikleri:BaseEntity
    {  
        public string OtelSubID { get; set; }
        public string OlanakAdi { get; set; }
    }
}
