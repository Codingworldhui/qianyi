namespace qianyi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class YourMigrationName : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Products");
            AlterColumn("dbo.Products", "Name", c => c.String());
            AlterColumn("dbo.Products", "Price", c => c.Double(nullable: false));
            AddPrimaryKey("dbo.Products", "Price");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Products");
            AlterColumn("dbo.Products", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Products", "Name");
        }
    }
}
