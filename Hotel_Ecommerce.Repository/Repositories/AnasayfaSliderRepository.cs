using Hotel_Ecommerce.Repository.Interfaces;
using Hotel_Ecoomerce.DAL.Concrete;
using Hotel_Ecoomerce.DAL.Context;

namespace Hotel_Ecommerce.Repository.Repositories
{
    public class AnasayfaSliderRepository : Repository<AnasayfaSlider>, IAnasayfaSlider
    {
        DatabaseContext _context; 
        public AnasayfaSliderRepository(DatabaseContext db) : base(db)
        { 
            _context = db;
        }
    } 
}
