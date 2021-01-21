using Hotel_Ecommerce.Repository.Interfaces;
using Hotel_Ecoomerce.DAL.Concrete;
using Hotel_Ecoomerce.DAL.Context;

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
