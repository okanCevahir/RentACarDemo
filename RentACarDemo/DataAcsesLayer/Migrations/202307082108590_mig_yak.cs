namespace DataAcsesLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_yak : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cars", "Yakit", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cars", "Yakit", c => c.Double(nullable: false));
        }
    }
}
