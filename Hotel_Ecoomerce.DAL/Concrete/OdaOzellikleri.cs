using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_Ecoomerce.DAL.Concrete
{
    [Table("OdaOzellikleri")]
    public class OdaOzellikleri : BaseEntity
    { 
        public string OtelSubID { get; set; }
        public string OdaOzellikAdi { get; set; }
    }
} 
 