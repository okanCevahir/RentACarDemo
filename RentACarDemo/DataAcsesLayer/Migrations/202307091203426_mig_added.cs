namespace DataAcsesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "Statu", c => c.Boolean(nullable: false));
            AddColumn("dbo.Cars", "Price", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "Price");
            DropColumn("dbo.Cars", "Statu");
        }
    }
}
