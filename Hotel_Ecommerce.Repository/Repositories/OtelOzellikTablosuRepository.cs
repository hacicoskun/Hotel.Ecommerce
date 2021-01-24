using Hotel_Ecommerce.Repository.Interfaces;
using Hotel_Ecommerce.DAL.Concrete;
using Hotel_Ecommerce.DAL.Context;

namespace Hotel_Ecommerce.Repository.Repositories
{

    public class OtelOzellikTablosuRepository : Repository<OtelOzellikTablosu>, IOtelOzellikTablosu
    {
        DatabaseContext _context;
        public OtelOzellikTablosuRepository(DatabaseContext db) : base(db)
        {
            _context = db;
        }
    }
}
