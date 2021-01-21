using Hotel_Ecommerce.Repository.Interfaces;
using Hotel_Ecoomerce.DAL.Concrete;
using Hotel_Ecoomerce.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Ecommerce.Repository.Repositories
{
    
    public class OdaOzellikleriRepository : Repository<OdaOzellikleri>, IOdaOzellikleri
    {
        DatabaseContext _context;
        public OdaOzellikleriRepository(DatabaseContext db) : base(db)
        {
            _context = db;
        }
    }
}
