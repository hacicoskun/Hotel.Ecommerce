using Hotel_Ecommerce.Repository.Interfaces;
using Hotel_Ecoomerce.DAL.Concrete;
using Hotel_Ecoomerce.DAL.Context;

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
