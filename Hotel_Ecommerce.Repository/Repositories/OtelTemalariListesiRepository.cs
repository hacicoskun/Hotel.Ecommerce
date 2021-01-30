using Hotel_Ecommerce.Repository.Interfaces;
using Hotel_Ecommerce.DAL.Concrete;
using Hotel_Ecommerce.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Ecommerce.Repository.Repositories
{

    public class OtelTemalariListesiRepository : Repository<OtelTemalariListesi>, IOtelTemalariListesi
    {
        DatabaseContext _context;
        public OtelTemalariListesiRepository(DatabaseContext db) : base(db)
        {
            _context = db;
        }
    }
}
