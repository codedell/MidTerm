namespace DellMT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RevoveCourseListFromStudent : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.StudentCourses", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.StudentCourses", "Course_Id", "dbo.Courses");
            DropIndex("dbo.StudentCourses", new[] { "Student_Id" });
            DropIndex("dbo.StudentCourses", new[] { "Course_Id" });
            CreateIndex("dbo.Students", "CourseId");
            AddForeignKey("dbo.Students", "CourseId", "dbo.Courses", "Id", cascadeDelete: true);
            DropTable("dbo.StudentCourses");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.StudentCourses",
                c => new
                    {
                        Student_Id = c.Int(nullable: false),
                        Course_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_Id, t.Course_Id });
            
            DropForeignKey("dbo.Students", "CourseId", "dbo.Courses");
            DropIndex("dbo.Students", new[] { "CourseId" });
            CreateIndex("dbo.StudentCourses", "Course_Id");
            CreateIndex("dbo.StudentCourses", "Student_Id");
            AddForeignKey("dbo.StudentCourses", "Course_Id", "dbo.Courses", "Id", cascadeDelete: true);
            AddForeignKey("dbo.StudentCourses", "Student_Id", "dbo.Students", "Id", cascadeDelete: true);
        }
    }
}
