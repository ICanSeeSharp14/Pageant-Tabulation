namespace Tabulation_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropForeignKeyFromCategoryTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Categories", "EventId", "dbo.Events");
            DropIndex("dbo.Categories", new[] { "EventId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Categories", "EventId");
            AddForeignKey("dbo.Categories", "EventId", "dbo.Events", "Id", cascadeDelete: true);
        }
    }
}
