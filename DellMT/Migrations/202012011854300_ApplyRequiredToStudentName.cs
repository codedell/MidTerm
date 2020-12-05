namespace DellMT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyRequiredToStudentName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "FirstName", c => c.String(nullable: false, maxLength: 125));
            AlterColumn("dbo.Students", "LastName", c => c.String(nullable: false, maxLength: 125));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "LastName", c => c.String());
            AlterColumn("dbo.Students", "FirstName", c => c.String());
        }
    }
}
