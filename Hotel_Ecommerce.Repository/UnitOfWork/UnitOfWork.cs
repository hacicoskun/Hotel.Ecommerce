using Hotel_Ecommerce.Repository.Interfaces;
using Hotel_Ecommerce.Repository.Repositories;
using Hotel_Ecoomerce.DAL.Context;
using System;

namespace MevsimTazesi.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
      
        public IAnasayfaSlider AnasayfaSlider { get; }
        public IBiziTakipEdin BiziTakipEdin { get; }    
        public IIletisim Iletisim { get; }
        public ILoginUsers LoginUsers { get; }
        public IOdaOzellikleri OdaOzellikleri { get; }
        public IOdaOzellikTablosu OdaOzellikTablosu { get; }
        public IOteller Oteller  { get; }
        public IOtelOzellikleri OtelOzellikleri { get; }
        public IOtelOzellikTablosu OtelOzellikTablosu  { get; }
        public IOtelTeklifleri OtelTeklifleri  { get; }
        public ISiziArayalim SiziArayalim  { get; }
        public IYorumlar Yorumlar  { get; }

        private readonly DatabaseContext _context;

        public UnitOfWork()
        {
            _context = new DatabaseContext();
            AnasayfaSlider = new AnasayfaSliderRepository(_context);
            BiziTakipEdin = new BiziTakipEdinRepository(_context);
            Iletisim = new IletisimRepository(_context);
            LoginUsers = new LoginUsersRepository(_context);
            OdaOzellikleri = new OdaOzellikleriRepository(_context);
            OdaOzellikTablosu = new OdaOzellikTablosuRepository(_context);
            Oteller = new OtellerRepository(_context);
            OtelOzellikleri = new OtelOzellikleriRepository(_context);
            OtelOzellikTablosu = new OtelOzellikTablosuRepository(_context);
            OtelTeklifleri = new OtelTeklifleriRepository(_context);
            SiziArayalim = new SiziArayalimRepository(_context);
            Yorumlar = new YorumlarRepository(_context);
            
        }
        public void Dispose()
        {
            _context.Dispose();
        }
        public int Save()
        {
            try
            {
                return _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}
