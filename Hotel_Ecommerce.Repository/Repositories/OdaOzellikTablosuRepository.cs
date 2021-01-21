using Hotel_Ecommerce.Repository.Interfaces;
using Hotel_Ecoomerce.DAL.Concrete;
using Hotel_Ecoomerce.DAL.Context;

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
