using Hotel_Ecommerce.Repository.Interfaces;
using Hotel_Ecoomerce.DAL.Concrete;
using Hotel_Ecoomerce.DAL.Context;

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
