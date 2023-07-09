namespace DataAcsesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_upp : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cars", "Statu", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cars", "Statu", c => c.String());
        }
    }
}
