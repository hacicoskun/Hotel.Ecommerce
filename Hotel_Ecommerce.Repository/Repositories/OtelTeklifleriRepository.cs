using Hotel_Ecommerce.Repository.Interfaces;
using Hotel_Ecoomerce.DAL.Concrete;
using Hotel_Ecoomerce.DAL.Context;

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
