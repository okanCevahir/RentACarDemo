namespace DataAcsesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_added1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Cars", "Yil");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cars", "Yil", c => c.DateTime(nullable: false));
        }
    }
}
