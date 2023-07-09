namespace DataAcsesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_car : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Marka = c.String(),
                        Model = c.String(),
                        Yil = c.DateTime(nullable: false),
                        Yakit = c.Double(nullable: false),
                        Vites = c.String(),
                        Km = c.Int(nullable: false),
                        Renk = c.String(),
                        Image = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cars");
        }
    }
}
