namespace Lab7MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Address = c.String(),
                        CampusID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.UniversityCampus", t => t.CampusID)
                .Index(t => t.CampusID);
            
            CreateTable(
                "dbo.UniversityCampus",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "CampusID", "dbo.UniversityCampus");
            DropIndex("dbo.Students", new[] { "CampusID" });
            DropTable("dbo.UniversityCampus");
            DropTable("dbo.Students");
        }
    }
}
