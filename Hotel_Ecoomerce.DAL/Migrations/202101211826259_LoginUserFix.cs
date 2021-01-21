namespace Hotel_Ecoomerce.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LoginUserFix : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LoginUsers", "AdSoyad", c => c.String());
            DropColumn("dbo.LoginUsers", "AktifMi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LoginUsers", "AktifMi", c => c.Boolean(nullable: false));
            DropColumn("dbo.LoginUsers", "AdSoyad");
        }
    }
}
