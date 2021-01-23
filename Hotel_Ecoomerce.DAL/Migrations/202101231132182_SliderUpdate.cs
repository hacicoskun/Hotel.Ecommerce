namespace Hotel_Ecoomerce.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SliderUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AnasayfaSlider", "Isım", c => c.String());
            AddColumn("dbo.AnasayfaSlider", "Düzen", c => c.Int(nullable: false));
            AddColumn("dbo.AnasayfaSlider", "Link", c => c.String());
            AddColumn("dbo.AnasayfaSlider", "Hedef", c => c.String());
            AddColumn("dbo.AnasayfaSlider", "Tip", c => c.String());
            DropColumn("dbo.AnasayfaSlider", "SliderResim");
            DropColumn("dbo.AnasayfaSlider", "SliderTarget");
            DropColumn("dbo.AnasayfaSlider", "SliderLink");
            DropColumn("dbo.AnasayfaSlider", "AktifMi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AnasayfaSlider", "AktifMi", c => c.Boolean(nullable: false));
            AddColumn("dbo.AnasayfaSlider", "SliderLink", c => c.String());
            AddColumn("dbo.AnasayfaSlider", "SliderTarget", c => c.String());
            AddColumn("dbo.AnasayfaSlider", "SliderResim", c => c.String());
            DropColumn("dbo.AnasayfaSlider", "Tip");
            DropColumn("dbo.AnasayfaSlider", "Hedef");
            DropColumn("dbo.AnasayfaSlider", "Link");
            DropColumn("dbo.AnasayfaSlider", "Düzen");
            DropColumn("dbo.AnasayfaSlider", "Isım");
        }
    }
}
