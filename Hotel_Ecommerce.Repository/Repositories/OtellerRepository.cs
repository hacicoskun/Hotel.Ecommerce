﻿using Hotel_Ecommerce.Repository.Interfaces;
using Hotel_Ecommerce.DAL.Concrete;
using Hotel_Ecommerce.DAL.Context;

namespace Hotel_Ecommerce.Repository.Repositories
{
    public class OtellerRepository : Repository<Oteller>, IOteller
    {
        DatabaseContext _context;
        public OtellerRepository(DatabaseContext db) : base(db)
        {
            _context = db;
        }
    }
}
