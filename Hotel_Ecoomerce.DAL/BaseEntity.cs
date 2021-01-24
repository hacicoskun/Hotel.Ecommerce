using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Ecommerce.DAL
{
    public class BaseEntity
    {
        [Key]
        public string _id { get; set; } = ObjectId.GenerateNewId().ToString(); //Mongo GUID üretme kodu->No sql e dönüş için _id yapıldı.
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public string UserID { get; set; }
    }
}
