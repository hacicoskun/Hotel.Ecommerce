using Hotel_Ecommerce.Repository.Interfaces;
using Hotel_Ecommerce.DAL.Concrete;
using Hotel_Ecommerce.DAL.Context;

namespace Hotel_Ecommerce.Repository.Repositories
{
    public class BiziTakipEdinRepository : Repository<BiziTakipEdin>, IBiziTakipEdin
    {
        DatabaseContext _context; 
        public BiziTakipEdinRepository(DatabaseContext db) : base(db)
        { 
            _context = db;
        }
    } 
}
