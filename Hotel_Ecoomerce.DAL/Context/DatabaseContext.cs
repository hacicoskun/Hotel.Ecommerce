using Hotel_Ecommerce.DAL.Concrete; 
using System;
using System.Data.Entity;

namespace Hotel_Ecommerce.DAL.Context
{
    public class DatabaseContext : DbContext, IDisposable
    {
        public DatabaseContext() : base("Data Source=94.73.146.4;Initial Catalog=u9491448_hotel; User Id=u9491448_hotelUs;Password=GHvn11N5BGyc48V;") { }
        public DbSet<AnasayfaSlider> AnasayfaSlider { get; set; }
        public DbSet<BiziTakipEdin> PanelUsers { get; set; }
        public DbSet<Iletisim> Iletisim { get; set; }
        public DbSet<LoginUsers> LoginUsers { get; set; }
        public DbSet<OdaOzellikleri> OdaOzellikleri { get; set; }
        public DbSet<OdaOzellikListesi> OdaOzellikListesi { get; set; }
        public DbSet<Oteller> Oteller { get; set; }
        public DbSet<OtelOzellikleri> OtelOzellikleri { get; set; } 
        public DbSet<OtelOzellikListesi> OtelOzellikListesi { get; set; }
        public DbSet<OtelTemalari> OtelTemalari { get; set; }
        public DbSet<OtelTemalariListesi> OtelTemalariListesi { get; set; }
        public DbSet<OtelTeklifleri> OtelTeklifleri { get; set; }
        public DbSet<SiziArayalim> SiziArayalim { get; set; } 
        public DbSet<Yorumlar> Yorumlar { get; set; }
        public DbSet<SayfalarMenusu> SayfalarMenusu { get; set; }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
         }
    }
}
