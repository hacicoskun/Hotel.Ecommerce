namespace Hotel_Ecoomerce.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AnasayfaSlider",
                c => new
                    {
                        _id = c.String(nullable: false, maxLength: 128),
                        SliderResim = c.String(),
                        SliderTarget = c.String(),
                        SliderLink = c.String(),
                        SliderBaslangicTarihi = c.DateTime(nullable: false),
                        SliderBitisTarihi = c.DateTime(nullable: false),
                        AktifMi = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UserID = c.String(),
                    })
                .PrimaryKey(t => t._id);
            
            CreateTable(
                "dbo.Iletisim",
                c => new
                    {
                        _id = c.String(nullable: false, maxLength: 128),
                        Adsoyad = c.String(),
                        Email = c.String(),
                        Telefon = c.String(),
                        Departman = c.String(),
                        Baslik = c.String(),
                        Mesaj = c.String(),
                        Ipadresi = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UserID = c.String(),
                    })
                .PrimaryKey(t => t._id);
            
            CreateTable(
                "dbo.LoginUsers",
                c => new
                    {
                        _id = c.String(nullable: false, maxLength: 128),
                        KullaniciAdi = c.String(),
                        Sifre = c.String(),
                        AktifMi = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UserID = c.String(),
                    })
                .PrimaryKey(t => t._id);
            
            CreateTable(
                "dbo.OdaOzellikleri",
                c => new
                    {
                        _id = c.String(nullable: false, maxLength: 128),
                        OtelSubID = c.String(),
                        OdaOzellikAdi = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UserID = c.String(),
                    })
                .PrimaryKey(t => t._id);
            
            CreateTable(
                "dbo.OdaOzellikTablosu",
                c => new
                    {
                        _id = c.String(nullable: false, maxLength: 128),
                        OdaOzellikAdi = c.String(),
                    })
                .PrimaryKey(t => t._id);
            
            CreateTable(
                "dbo.Oteller",
                c => new
                    {
                        _id = c.String(nullable: false, maxLength: 128),
                        OtelAdi = c.String(),
                        OtelKisaBilgi = c.String(),
                        OtelBolgesi = c.String(),
                        Otelil = c.String(),
                        Otelilce = c.String(),
                        OtelXYKoordinat = c.String(),
                        KonaklamaTipi = c.String(),
                        OtelDivBilgi = c.String(),
                        OtelAciklama = c.String(),
                        OtelGoruntulenmeSayisi = c.Int(nullable: false),
                        OtelDosyaLink = c.String(),
                        OtelAnasayfaResmi = c.String(),
                        OtelGaleriKlasor = c.String(),
                        OtelEklenmeTarihi = c.DateTime(nullable: false),
                        OtelAktifMi = c.Boolean(nullable: false),
                        OtelPuan = c.Int(nullable: false),
                        OtelOncelik = c.Boolean(nullable: false),
                        OtelLink = c.String(),
                        OtelSezonu = c.String(),
                        OdaAciklama = c.String(),
                        SehirOteli = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UserID = c.String(),
                    })
                .PrimaryKey(t => t._id);
            
            CreateTable(
                "dbo.OtelOzellikleri",
                c => new
                    {
                        _id = c.String(nullable: false, maxLength: 128),
                        OtelSubID = c.String(),
                        OlanakAdi = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UserID = c.String(),
                    })
                .PrimaryKey(t => t._id);
            
            CreateTable(
                "dbo.OtelOzellikTablosu",
                c => new
                    {
                        _id = c.String(nullable: false, maxLength: 128),
                        OtelOzellik = c.String(),
                    })
                .PrimaryKey(t => t._id);
            
            CreateTable(
                "dbo.OtelTeklifleri",
                c => new
                    {
                        _id = c.String(nullable: false, maxLength: 128),
                        OtelAdi = c.String(),
                        Adsoyad = c.String(),
                        Telefon = c.String(),
                        Email = c.String(),
                        YetiskinSayisi = c.String(),
                        CocukSayisi = c.String(),
                        Cocuk1Yas = c.String(),
                        Cocuk2Yas = c.String(),
                        Ipadresi = c.String(),
                        RezTarihi = c.String(),
                        IslemTarihi = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UserID = c.String(),
                    })
                .PrimaryKey(t => t._id);
            
            CreateTable(
                "dbo.BiziTakipEdin",
                c => new
                    {
                        _id = c.String(nullable: false, maxLength: 128),
                        Adsoyad = c.String(),
                        Email = c.String(),
                        Ipadresi = c.String(),
                        IslemTarihi = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UserID = c.String(),
                    })
                .PrimaryKey(t => t._id);
            
            CreateTable(
                "dbo.SiziArayalim",
                c => new
                    {
                        _id = c.String(nullable: false, maxLength: 128),
                        Adsoyad = c.String(),
                        Telefon = c.String(),
                        Email = c.String(),
                        Konu = c.String(),
                        Aramatarihi = c.String(),
                        Aramazamani = c.String(),
                        Ipadresi = c.String(),
                        Islemtarihi = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UserID = c.String(),
                    })
                .PrimaryKey(t => t._id);
            
            CreateTable(
                "dbo.Yorumlar",
                c => new
                    {
                        _id = c.String(nullable: false, maxLength: 128),
                        OtelID = c.String(),
                        OtelAdi = c.String(),
                        YorumAtanKisi = c.String(),
                        YorumBaslik = c.String(),
                        YorumTelefon = c.String(),
                        YorumDetay = c.String(),
                        YorumTarihi = c.String(),
                        YorunIpAdress = c.String(),
                        YorumAktifMi = c.Boolean(nullable: false),
                        YorumPuan1 = c.Int(nullable: false),
                        YorumPuan2 = c.Int(nullable: false),
                        YorumPuan3 = c.Int(nullable: false),
                        YorumEmail = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UserID = c.String(),
                    })
                .PrimaryKey(t => t._id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Yorumlar");
            DropTable("dbo.SiziArayalim");
            DropTable("dbo.BiziTakipEdin");
            DropTable("dbo.OtelTeklifleri");
            DropTable("dbo.OtelOzellikTablosu");
            DropTable("dbo.OtelOzellikleri");
            DropTable("dbo.Oteller");
            DropTable("dbo.OdaOzellikTablosu");
            DropTable("dbo.OdaOzellikleri");
            DropTable("dbo.LoginUsers");
            DropTable("dbo.Iletisim");
            DropTable("dbo.AnasayfaSlider");
        }
    }
}
