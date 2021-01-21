using Hotel_Ecommerce.Repository.Interfaces;
using Hotel_Ecoomerce.DAL.Concrete;
using Hotel_Ecoomerce.DAL.Context;

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
