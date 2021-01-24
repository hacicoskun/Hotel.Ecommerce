using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_Ecommerce.DAL.Concrete
{
    [Table("OdaOzellikleri")]
    public class OdaOzellikleri : BaseEntity
    { 
        public string OtelSubID { get; set; }
        public string OdaOzellikAdi { get; set; }
    }
} 
 