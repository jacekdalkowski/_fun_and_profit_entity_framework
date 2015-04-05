namespace EFCodeFirstPersistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeSurname_Unique : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Employees", "Surname", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Employees", new[] { "Surname" });
        }
    }
}
