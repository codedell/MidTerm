namespace DellMT2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataLengthChanged : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "CourseName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Courses", "CourseDescription", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Courses", "TutorName", c => c.String(nullable: false, maxLength: 61));
            AlterColumn("dbo.CourseStatus", "Status", c => c.String(maxLength: 30));
            AlterColumn("dbo.Students", "FirstName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Students", "LastName", c => c.String(maxLength: 30));
            AlterColumn("dbo.Students", "Grade", c => c.String(nullable: false, maxLength: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Grade", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "LastName", c => c.String());
            AlterColumn("dbo.Students", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.CourseStatus", "Status", c => c.String());
            AlterColumn("dbo.Courses", "TutorName", c => c.String(nullable: false));
            AlterColumn("dbo.Courses", "CourseDescription", c => c.String(nullable: false));
            AlterColumn("dbo.Courses", "CourseName", c => c.String(nullable: false));
        }
    }
}
