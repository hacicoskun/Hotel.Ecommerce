using Hotel_Ecommerce.DAL.Concrete;
using Hotel_Ecommerce.DAL.Context;
using Hotel_Ecommerce.Repository.Interfaces;

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
