using Hotel_Ecommerce.Repository.Interfaces;
using Hotel_Ecommerce.DAL.Concrete;
using Hotel_Ecommerce.DAL.Context;

namespace Hotel_Ecommerce.Repository.Repositories
{

    public class SiziArayalimRepository : Repository<SiziArayalim>, ISiziArayalim
    {
        DatabaseContext _context;
        public SiziArayalimRepository(DatabaseContext db) : base(db)
        {
            _context = db;
        }
    }
}
