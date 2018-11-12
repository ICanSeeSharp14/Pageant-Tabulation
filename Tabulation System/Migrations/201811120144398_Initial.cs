namespace Tabulation_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Candidates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CandidateNo = c.Int(nullable: false),
                        MiddleName = c.String(),
                        HomeTown = c.String(),
                        Gender = c.Int(nullable: false),
                        Attainment = c.String(),
                        School = c.String(),
                        Course = c.String(),
                        YearLevel = c.String(),
                        Weight = c.String(),
                        Height = c.String(),
                        Biography = c.String(),
                        Hipline = c.Double(nullable: false),
                        Waistline = c.Double(nullable: false),
                        Bustline = c.Double(nullable: false),
                        Image = c.Byte(),
                        IsActive = c.Boolean(),
                        DateTimeCreated = c.DateTime(),
                        CreatedBy = c.Int(),
                        DateTimeModified = c.DateTime(),
                        ModifiedBy = c.Int(),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sequence = c.Int(),
                        EventId = c.Int(nullable: false),
                        CategoryName = c.String(),
                        Description = c.String(),
                        Percentage = c.Double(nullable: false),
                        IsActive = c.Boolean(),
                        DateTimeCreated = c.DateTime(),
                        CreatedBy = c.Int(),
                        DateTimeModified = c.DateTime(),
                        ModifiedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Events", t => t.EventId, cascadeDelete: true)
                .Index(t => t.EventId);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EventTitle = c.String(),
                        EventDate = c.DateTime(),
                        Location = c.String(),
                        IsActive = c.Boolean(),
                        DateTimeCreated = c.DateTime(),
                        CreatedBy = c.Int(),
                        DateTimeModified = c.DateTime(),
                        ModifiedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Results",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JudgeNo = c.Int(nullable: false),
                        CriteriaId = c.Int(nullable: false),
                        Score = c.Double(nullable: false),
                        IsActive = c.Boolean(),
                        DateTimeCreated = c.DateTime(),
                        CreatedBy = c.Int(),
                        DateTimeModified = c.DateTime(),
                        ModifiedBy = c.Int(),
                        Judge_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Criteria", t => t.CriteriaId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.Judge_Id)
                .Index(t => t.CriteriaId)
                .Index(t => t.Judge_Id);
            
            CreateTable(
                "dbo.Criteria",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(nullable: false),
                        CriteriaName = c.String(),
                        Percentage = c.Int(nullable: false),
                        MinimumScore = c.Double(nullable: false),
                        IsActive = c.Boolean(),
                        DateTimeCreated = c.DateTime(),
                        CreatedBy = c.Int(),
                        DateTimeModified = c.DateTime(),
                        ModifiedBy = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                        UserType = c.Int(nullable: false),
                        IsActive = c.Boolean(),
                        DateTimeCreated = c.DateTime(),
                        CreatedBy = c.Int(),
                        DateTimeModified = c.DateTime(),
                        ModifiedBy = c.Int(),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Results", "Judge_Id", "dbo.Users");
            DropForeignKey("dbo.Results", "CriteriaId", "dbo.Criteria");
            DropForeignKey("dbo.Criteria", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Categories", "EventId", "dbo.Events");
            DropIndex("dbo.Criteria", new[] { "CategoryId" });
            DropIndex("dbo.Results", new[] { "Judge_Id" });
            DropIndex("dbo.Results", new[] { "CriteriaId" });
            DropIndex("dbo.Categories", new[] { "EventId" });
            DropTable("dbo.Users");
            DropTable("dbo.Criteria");
            DropTable("dbo.Results");
            DropTable("dbo.Events");
            DropTable("dbo.Categories");
            DropTable("dbo.Candidates");
        }
    }
}
