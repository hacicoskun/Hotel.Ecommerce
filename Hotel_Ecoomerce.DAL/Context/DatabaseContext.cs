using Hotel_Ecoomerce.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Ecoomerce.DAL.Context
{
    public class DatabaseContext : DbContext, IDisposable
    {
        public DatabaseContext() : base("Server=DESKTOP-7MPM6RE;Database=Hotel_Ecommerce;Trusted_Connection=True;") { }
        public DbSet<AnasayfaSlider> AnasayfaSlider { get; set; }
        public DbSet<BiziTakipEdin> PanelUsers { get; set; }
        public DbSet<Iletisim> Iletisim { get; set; }
        public DbSet<LoginUsers> LoginUsers { get; set; }
        public DbSet<OdaOzellikleri> OdaOzellikleri { get; set; }
        public DbSet<OdaOzellikTablosu> OdaOzellikTablosu { get; set; }
        public DbSet<Oteller> Oteller { get; set; }
        public DbSet<OtelOzellikleri> OtelOzellikleri { get; set; }
 
        public DbSet<OtelOzellikTablosu> OtelOzellikTablosu { get; set; }
        public DbSet<OtelTeklifleri> OtelTeklifleri { get; set; }
        public DbSet<SiziArayalim> SiziArayalim { get; set; } 
        public DbSet<Yorumlar> Yorumlar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
         }
    }
}
