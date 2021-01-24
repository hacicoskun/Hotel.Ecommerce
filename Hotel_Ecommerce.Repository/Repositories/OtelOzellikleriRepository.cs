using Hotel_Ecommerce.Repository.Interfaces;
using Hotel_Ecommerce.DAL.Concrete;
using Hotel_Ecommerce.DAL.Context;

namespace Hotel_Ecommerce.Repository.Repositories
{

    public class OtelOzellikleriRepository : Repository<OtelOzellikleri>, IOtelOzellikleri
    {
        DatabaseContext _context;
        public OtelOzellikleriRepository(DatabaseContext db) : base(db)
        {
            _context = db;
        }
    }
}
