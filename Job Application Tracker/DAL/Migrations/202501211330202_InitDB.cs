namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Applications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        position = c.String(),
                        company = c.String(),
                        DateApplied = c.DateTime(nullable: false),
                        status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Notes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NoteText = c.String(),
                        AppId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Applications", t => t.AppId, cascadeDelete: true)
                .Index(t => t.AppId);

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Notes", "AppId", "dbo.Applications");
            DropIndex("dbo.Notes", new[] { "AppId" });
            DropTable("dbo.Notes");
            DropTable("dbo.Applications");
        }
    }
}
