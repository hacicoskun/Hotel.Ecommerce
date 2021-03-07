using Hotel_Ecommerce.DAL.Concrete;
using Hotel_Ecommerce.DAL.Context;
using Hotel_Ecommerce.Repository.Interfaces;

namespace Hotel_Ecommerce.Repository.Repositories
{

    public class SayfalarMenusuRepository : Repository<SayfalarMenusu>, ISayfalarMenusu
    {
        DatabaseContext _context;
        public SayfalarMenusuRepository(DatabaseContext db) : base(db)
        {
            _context = db;
        }
    }
}
