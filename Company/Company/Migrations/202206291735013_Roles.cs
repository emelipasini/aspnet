namespace Company.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Roles : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Role", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Role");
        }
    }
}
