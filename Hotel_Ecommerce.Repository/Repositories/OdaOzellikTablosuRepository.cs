using Hotel_Ecommerce.Repository.Interfaces;
using Hotel_Ecommerce.DAL.Concrete;
using Hotel_Ecommerce.DAL.Context;

namespace Hotel_Ecommerce.Repository.Repositories
{

    public class OdaOzellikTablosuRepository : Repository<OdaOzellikTablosu>, IOdaOzellikTablosu
    {
        DatabaseContext _context;
        public OdaOzellikTablosuRepository(DatabaseContext db) : base(db)
        {
            _context = db;
        }
    }
}
