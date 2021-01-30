using Hotel_Ecommerce.Repository.Interfaces;
using Hotel_Ecommerce.DAL.Concrete;
using Hotel_Ecommerce.DAL.Context;

namespace Hotel_Ecommerce.Repository.Repositories
{

    public class OtelOzellikListesiRepository : Repository<OtelOzellikListesi>, IOtelOzellikListesi
    {
        DatabaseContext _context;
        public OtelOzellikListesiRepository(DatabaseContext db) : base(db)
        {
            _context = db;
        }
    }
}
