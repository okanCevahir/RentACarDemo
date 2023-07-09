namespace DataAcsesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg_back : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "Yil", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "Yil");
        }
    }
}
