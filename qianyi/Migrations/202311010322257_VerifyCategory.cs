namespace qianyi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VerifyCategory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cates",
                c => new
                    {
                        Category = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Category);
            
            AddColumn("dbo.Products", "Category_Category", c => c.String(maxLength: 128));
            CreateIndex("dbo.Products", "Category_Category");
            AddForeignKey("dbo.Products", "Category_Category", "dbo.Cates", "Category");
            DropColumn("dbo.Products", "Category");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Category", c => c.String());
            DropForeignKey("dbo.Products", "Category_Category", "dbo.Cates");
            DropIndex("dbo.Products", new[] { "Category_Category" });
            DropColumn("dbo.Products", "Category_Category");
            DropTable("dbo.Cates");
        }
    }
}
