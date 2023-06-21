namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Headings", "Category_CategoryID", "dbo.Categories");
            DropIndex("dbo.Headings", new[] { "Category_CategoryID" });
            RenameColumn(table: "dbo.Headings", name: "Category_CategoryID", newName: "CategoryID");
            AlterColumn("dbo.Headings", "CategoryID", c => c.Int(nullable: false));
            CreateIndex("dbo.Headings", "CategoryID");
            AddForeignKey("dbo.Headings", "CategoryID", "dbo.Categories", "CategoryID", cascadeDelete: true);
            DropColumn("dbo.Headings", "CtaegoryID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Headings", "CtaegoryID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Headings", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Headings", new[] { "CategoryID" });
            AlterColumn("dbo.Headings", "CategoryID", c => c.Int());
            RenameColumn(table: "dbo.Headings", name: "CategoryID", newName: "Category_CategoryID");
            CreateIndex("dbo.Headings", "Category_CategoryID");
            AddForeignKey("dbo.Headings", "Category_CategoryID", "dbo.Categories", "CategoryID");
        }
    }
}
