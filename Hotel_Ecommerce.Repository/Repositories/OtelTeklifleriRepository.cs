using Hotel_Ecommerce.Repository.Interfaces;
using Hotel_Ecommerce.DAL.Concrete;
using Hotel_Ecommerce.DAL.Context;

namespace Hotel_Ecommerce.Repository.Repositories
{

    public class OtelTeklifleriRepository : Repository<OtelTeklifleri>, IOtelTeklifleri
    {
        DatabaseContext _context;
        public OtelTeklifleriRepository(DatabaseContext db) : base(db)
        {
            _context = db;
        }
    }
}
