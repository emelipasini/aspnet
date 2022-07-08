namespace Identity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedDBContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        Description = c.String(maxLength: 140),
                    })
                .PrimaryKey(t => t.ClientId);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectId = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 20),
                        Description = c.String(maxLength: 140),
                        Repository = c.String(nullable: false),
                        Board = c.String(nullable: false),
                        Deploy = c.String(),
                    })
                .PrimaryKey(t => t.ProjectId)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        ProjectId = c.Int(nullable: false),
                        Firstname = c.String(nullable: false, maxLength: 20),
                        Lastname = c.String(nullable: false, maxLength: 20),
                        RegistrationDate = c.DateTime(nullable: false),
                        DateofBirth = c.DateTime(nullable: false),
                        Absences = c.Int(nullable: false),
                        Salary = c.Int(nullable: false),
                        Role = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Projects", t => t.ProjectId, cascadeDelete: true)
                .Index(t => t.ProjectId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "ProjectId", "dbo.Projects");
            DropForeignKey("dbo.Projects", "ClientId", "dbo.Clients");
            DropIndex("dbo.Employees", new[] { "ProjectId" });
            DropIndex("dbo.Projects", new[] { "ClientId" });
            DropTable("dbo.Employees");
            DropTable("dbo.Projects");
            DropTable("dbo.Clients");
        }
    }
}
