using Hotel_Ecommerce.Repository.Interfaces;
using Hotel_Ecommerce.DAL.Concrete;
using Hotel_Ecommerce.DAL.Context;

namespace Hotel_Ecommerce.Repository.Repositories
{

    public class OdaOzellikListesiRepository : Repository<OdaOzellikListesi>, IOdaOzellikListesi
    {
        DatabaseContext _context;
        public OdaOzellikListesiRepository(DatabaseContext db) : base(db)
        {
            _context = db;
        }
    }
}
