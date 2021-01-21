namespace Hotel_Ecoomerce.DAL.Migrations
{
    using Hotel_Ecoomerce.DAL.Concrete;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Hotel_Ecoomerce.DAL.Context.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            //this.AutomaticMigrationDataLossAllowed = true;

        }

        protected override void Seed(Hotel_Ecoomerce.DAL.Context.DatabaseContext context)
        {
            if (!context.OtelOzellikTablosu.Any())
            {
                List<OtelOzellikTablosu> otelOzellikTablosu = new List<OtelOzellikTablosu>();
                otelOzellikTablosu.Add(new OtelOzellikTablosu { OtelOzellik = "Aqua Park" });
                otelOzellikTablosu.Add(new OtelOzellikTablosu { OtelOzellik = "Casino" });
                otelOzellikTablosu.Add(new OtelOzellikTablosu { OtelOzellik = "Buhar Odası" });
                otelOzellikTablosu.Add(new OtelOzellikTablosu { OtelOzellik = "Sauna" });
                otelOzellikTablosu.Add(new OtelOzellikTablosu { OtelOzellik = "Animasyon" });
                otelOzellikTablosu.Add(new OtelOzellikTablosu { OtelOzellik = "Kapalı Havuz" });
                otelOzellikTablosu.Add(new OtelOzellikTablosu { OtelOzellik = "Otopark" });
                otelOzellikTablosu.Add(new OtelOzellikTablosu { OtelOzellik = "Kablosuz İnternet" });
                otelOzellikTablosu.Add(new OtelOzellikTablosu { OtelOzellik = "Hamam" });
                otelOzellikTablosu.Add(new OtelOzellikTablosu { OtelOzellik = "Açık Havuz" });
                otelOzellikTablosu.Add(new OtelOzellikTablosu { OtelOzellik = "Fitness Center" });
                otelOzellikTablosu.Add(new OtelOzellikTablosu { OtelOzellik = "Masaj" });
                otelOzellikTablosu.Add(new OtelOzellikTablosu { OtelOzellik = "Toplantı Salonu" });
                otelOzellikTablosu.Add(new OtelOzellikTablosu { OtelOzellik = "Doktor" });
                otelOzellikTablosu.Add(new OtelOzellikTablosu { OtelOzellik = "Emanet Kasa" });
                otelOzellikTablosu.Add(new OtelOzellikTablosu { OtelOzellik = "Oyun Salonu" });
                otelOzellikTablosu.Add(new OtelOzellikTablosu { OtelOzellik = "Motorlu Su Sporları" });
                otelOzellikTablosu.Add(new OtelOzellikTablosu { OtelOzellik = "Şezlong" });
                context.OtelOzellikTablosu.AddRange(otelOzellikTablosu);
                context.SaveChanges(); 
            }
            if (!context.OdaOzellikTablosu.Any())
            {
                List<OdaOzellikTablosu> odaOzellikTablosu = new List<OdaOzellikTablosu>();
                odaOzellikTablosu.Add(new OdaOzellikTablosu { OdaOzellikAdi = "Açık Büfe Kahvaltı" });
                odaOzellikTablosu.Add(new OdaOzellikTablosu { OdaOzellikAdi = "Odaya Servis" });
                odaOzellikTablosu.Add(new OdaOzellikTablosu { OdaOzellikAdi = "LCD Smart TV & Uydu Yayını" });
                odaOzellikTablosu.Add(new OdaOzellikTablosu { OdaOzellikAdi = "Otel genelinde ücretsiz WIFI" });
                odaOzellikTablosu.Add(new OdaOzellikTablosu { OdaOzellikAdi = "Uyandırma Servisi" });
                odaOzellikTablosu.Add(new OdaOzellikTablosu { OdaOzellikAdi = "Odaya ücretsiz kahvaltı servisi" });
                odaOzellikTablosu.Add(new OdaOzellikTablosu { OdaOzellikAdi = "Günlük Oda Temizliği" });
                odaOzellikTablosu.Add(new OdaOzellikTablosu { OdaOzellikAdi = "Saç kurutma makinası" });
                odaOzellikTablosu.Add(new OdaOzellikTablosu { OdaOzellikAdi = "Havlu" });
                odaOzellikTablosu.Add(new OdaOzellikTablosu { OdaOzellikAdi = "Tekstil ürünlerinin değişimi" });
                odaOzellikTablosu.Add(new OdaOzellikTablosu { OdaOzellikAdi = "Klima" });
                odaOzellikTablosu.Add(new OdaOzellikTablosu { OdaOzellikAdi = "Banyo" });
                odaOzellikTablosu.Add(new OdaOzellikTablosu { OdaOzellikAdi = "Odada kasa" });
                odaOzellikTablosu.Add(new OdaOzellikTablosu { OdaOzellikAdi = "Jakuzi" });
                odaOzellikTablosu.Add(new OdaOzellikTablosu { OdaOzellikAdi = "Minibar" });
                odaOzellikTablosu.Add(new OdaOzellikTablosu { OdaOzellikAdi = "Duş " });
                odaOzellikTablosu.Add(new OdaOzellikTablosu { OdaOzellikAdi = "Telefon" });
                context.OdaOzellikTablosu.AddRange(odaOzellikTablosu);
                context.SaveChanges();

            }
            base.Seed(context);
        }
    }
}
