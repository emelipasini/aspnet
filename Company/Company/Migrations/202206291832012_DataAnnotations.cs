namespace Company.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Firstname", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Employees", "Lastname", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Employees", "Role", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "Role", c => c.String(maxLength: 20));
            AlterColumn("dbo.Employees", "Lastname", c => c.String(maxLength: 20));
            AlterColumn("dbo.Employees", "Firstname", c => c.String(maxLength: 20));
        }
    }
}
