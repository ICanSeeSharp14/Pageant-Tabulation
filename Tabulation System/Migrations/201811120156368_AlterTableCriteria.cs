namespace Tabulation_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterTableCriteria : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Criteria", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Criteria", new[] { "CategoryId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Criteria", "CategoryId");
            AddForeignKey("dbo.Criteria", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
        }
    }
}
