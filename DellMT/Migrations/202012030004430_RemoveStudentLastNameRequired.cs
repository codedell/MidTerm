namespace DellMT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveStudentLastNameRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "LastName", c => c.String(maxLength: 125));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "LastName", c => c.String(nullable: false, maxLength: 125));
        }
    }
}
