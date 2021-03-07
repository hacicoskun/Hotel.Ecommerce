namespace Hotel_Ecommerce.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SayfalarMenusu : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.TurMenusu", newName: "SayfalarMenusu");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.SayfalarMenusu", newName: "TurMenusu");
        }
    }
}
