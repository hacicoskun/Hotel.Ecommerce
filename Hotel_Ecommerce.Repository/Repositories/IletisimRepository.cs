using Hotel_Ecommerce.Repository.Interfaces;
using Hotel_Ecoomerce.DAL.Concrete;
using Hotel_Ecoomerce.DAL.Context;

namespace Hotel_Ecommerce.Repository.Repositories
{
    public class IletisimRepository : Repository<Iletisim>, IIletisim
    {
        DatabaseContext _context; 
        public IletisimRepository(DatabaseContext db) : base(db)
        { 
            _context = db;
        }
    } 
}
