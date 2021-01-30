namespace Hotel_Ecommerce.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TurMenusu : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TurMenusu",
                c => new
                    {
                        _id = c.String(nullable: false, maxLength: 128),
                        Baslik = c.String(),
                        İcerik = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UserID = c.String(),
                    })
                .PrimaryKey(t => t._id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TurMenusu");
        }
    }
}
