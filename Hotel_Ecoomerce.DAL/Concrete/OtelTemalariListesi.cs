﻿using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Ecommerce.DAL.Concrete
{
    [Table("OtelTemalariListesi")]
    public class OtelTemalariListesi
    {
        [Key]
        public string _id { get; set; } = ObjectId.GenerateNewId().ToString();
        public string TemaAdi { get; set; }
    }
}
