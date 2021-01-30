namespace Hotel_Ecommerce.DAL.Migrations
{
    using Hotel_Ecommerce.DAL.Concrete;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Hotel_Ecommerce.DAL.Context.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            //this.AutomaticMigrationDataLossAllowed = true;

        }

        protected override void Seed(Hotel_Ecommerce.DAL.Context.DatabaseContext context)
        {
            if (!context.OtelOzellikListesi.Any())
            {
                List<OtelOzellikListesi> otelOzellikTablosu = new List<OtelOzellikListesi>();
                otelOzellikTablosu.Add(new OtelOzellikListesi { OtelOzellik = "Aqua Park" });
                otelOzellikTablosu.Add(new OtelOzellikListesi { OtelOzellik = "Casino" });
                otelOzellikTablosu.Add(new OtelOzellikListesi { OtelOzellik = "Buhar Odası" });
                otelOzellikTablosu.Add(new OtelOzellikListesi { OtelOzellik = "Sauna" });
                otelOzellikTablosu.Add(new OtelOzellikListesi { OtelOzellik = "Animasyon" });
                otelOzellikTablosu.Add(new OtelOzellikListesi { OtelOzellik = "Kapalı Havuz" });
                otelOzellikTablosu.Add(new OtelOzellikListesi { OtelOzellik = "Otopark" });
                otelOzellikTablosu.Add(new OtelOzellikListesi { OtelOzellik = "Kablosuz İnternet" });
                otelOzellikTablosu.Add(new OtelOzellikListesi { OtelOzellik = "Hamam" });
                otelOzellikTablosu.Add(new OtelOzellikListesi { OtelOzellik = "Açık Havuz" });
                otelOzellikTablosu.Add(new OtelOzellikListesi { OtelOzellik = "Fitness Center" });
                otelOzellikTablosu.Add(new OtelOzellikListesi { OtelOzellik = "Masaj" });
                otelOzellikTablosu.Add(new OtelOzellikListesi { OtelOzellik = "Toplantı Salonu" });
                otelOzellikTablosu.Add(new OtelOzellikListesi { OtelOzellik = "Doktor" });
                otelOzellikTablosu.Add(new OtelOzellikListesi { OtelOzellik = "Emanet Kasa" });
                otelOzellikTablosu.Add(new OtelOzellikListesi { OtelOzellik = "Oyun Salonu" });
                otelOzellikTablosu.Add(new OtelOzellikListesi { OtelOzellik = "Motorlu Su Sporları" });
                otelOzellikTablosu.Add(new OtelOzellikListesi { OtelOzellik = "Şezlong" });
                context.OtelOzellikListesi.AddRange(otelOzellikTablosu);
                context.SaveChanges(); 
            }
            if (!context.OdaOzellikListesi.Any())
            {
                List<OdaOzellikListesi> odaOzellikTablosu = new List<OdaOzellikListesi>();
                odaOzellikTablosu.Add(new OdaOzellikListesi { OdaOzellikAdi = "Açık Büfe Kahvaltı" });
                odaOzellikTablosu.Add(new OdaOzellikListesi { OdaOzellikAdi = "Odaya Servis" });
                odaOzellikTablosu.Add(new OdaOzellikListesi { OdaOzellikAdi = "LCD Smart TV & Uydu Yayını" });
                odaOzellikTablosu.Add(new OdaOzellikListesi { OdaOzellikAdi = "Otel genelinde ücretsiz WIFI" });
                odaOzellikTablosu.Add(new OdaOzellikListesi { OdaOzellikAdi = "Uyandırma Servisi" });
                odaOzellikTablosu.Add(new OdaOzellikListesi { OdaOzellikAdi = "Odaya ücretsiz kahvaltı servisi" });
                odaOzellikTablosu.Add(new OdaOzellikListesi { OdaOzellikAdi = "Günlük Oda Temizliği" });
                odaOzellikTablosu.Add(new OdaOzellikListesi { OdaOzellikAdi = "Saç kurutma makinası" });
                odaOzellikTablosu.Add(new OdaOzellikListesi { OdaOzellikAdi = "Havlu" });
                odaOzellikTablosu.Add(new OdaOzellikListesi { OdaOzellikAdi = "Tekstil ürünlerinin değişimi" });
                odaOzellikTablosu.Add(new OdaOzellikListesi { OdaOzellikAdi = "Klima" });
                odaOzellikTablosu.Add(new OdaOzellikListesi { OdaOzellikAdi = "Banyo" });
                odaOzellikTablosu.Add(new OdaOzellikListesi { OdaOzellikAdi = "Odada kasa" });
                odaOzellikTablosu.Add(new OdaOzellikListesi { OdaOzellikAdi = "Jakuzi" });
                odaOzellikTablosu.Add(new OdaOzellikListesi { OdaOzellikAdi = "Minibar" });
                odaOzellikTablosu.Add(new OdaOzellikListesi { OdaOzellikAdi = "Duş " });
                odaOzellikTablosu.Add(new OdaOzellikListesi { OdaOzellikAdi = "Telefon" });
                context.OdaOzellikListesi.AddRange(odaOzellikTablosu);
                context.SaveChanges();

            }
            if (!context.OtelTemalariListesi.Any())
            {
                List<OtelTemalariListesi> OtelTemalari = new List<OtelTemalariListesi>();
                OtelTemalari.Add(new OtelTemalariListesi { TemaAdi = "Becoming Öneriyor" });
                OtelTemalari.Add(new OtelTemalariListesi { TemaAdi = "Balayı Oteli" });
                OtelTemalari.Add(new OtelTemalariListesi { TemaAdi = "Aquapark Oteli" });
                OtelTemalari.Add(new OtelTemalariListesi { TemaAdi = "Bebek & Çocuk Dostu Otel" });
                OtelTemalari.Add(new OtelTemalariListesi { TemaAdi = "Kayak Oteli" });
                OtelTemalari.Add(new OtelTemalariListesi { TemaAdi = "Termal Otel" });
                OtelTemalari.Add(new OtelTemalariListesi { TemaAdi = "İş Oteli" });
                OtelTemalari.Add(new OtelTemalariListesi { TemaAdi = "Erken Rezerbasyon" });
                context.OtelTemalariListesi.AddRange(OtelTemalari);
                context.SaveChanges();

            }
            base.Seed(context);
        }
    }
}
