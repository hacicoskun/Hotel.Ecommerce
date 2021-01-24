using Hotel_Ecommerce.Repository.Interfaces;
using Hotel_Ecommerce.DAL.Concrete;
using Hotel_Ecommerce.DAL.Context;

namespace Hotel_Ecommerce.Repository.Repositories
{
    public class LoginUsersRepository : Repository<LoginUsers>, ILoginUsers
    {
        DatabaseContext _context; 
        public LoginUsersRepository(DatabaseContext db) : base(db)
        { 
            _context = db;
        }
    } 
}
