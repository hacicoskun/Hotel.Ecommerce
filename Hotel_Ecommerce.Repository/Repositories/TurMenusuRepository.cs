using Hotel_Ecommerce.DAL.Context;
using Hotel_Ecommerce.Repository.Interfaces;
using Hotel_Ecoomerce.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Ecommerce.Repository.Repositories
{

    public class TurMenusuRepository : Repository<TurMenusu>, ITurMenusu
    {
        DatabaseContext _context;
        public TurMenusuRepository(DatabaseContext db) : base(db)
        {
            _context = db;
        }
    }
}
