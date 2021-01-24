using Hotel_Ecommerce.Repository.Interfaces;
using Hotel_Ecommerce.DAL.Concrete;
using Hotel_Ecommerce.DAL.Context;

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
