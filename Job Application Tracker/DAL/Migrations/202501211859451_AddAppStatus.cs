namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAppStatus : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AppStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.String(nullable: false),
                        ApplicationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Applications", t => t.ApplicationId, cascadeDelete: true)
                .Index(t => t.ApplicationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AppStatus", "ApplicationId", "dbo.Applications");
            DropIndex("dbo.AppStatus", new[] { "ApplicationId" });
            DropTable("dbo.AppStatus");
        }
    }
}
