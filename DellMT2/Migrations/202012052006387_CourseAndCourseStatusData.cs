namespace DellMT2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CourseAndCourseStatusData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO COURSES(CourseName, CourseDescription, TutorName, CourseRating) VALUES ('Math', 'Algebra', 'Lebron James', '8')");

            Sql("INSERT INTO COURSES(CourseName, CourseDescription, TutorName, CourseRating) VALUES ('Science', 'Biology', 'Jon Jones', '7')");

            Sql("INSERT INTO COURSES(CourseName, CourseDescription, TutorName, CourseRating) VALUES ('Programming', 'C#', 'Kobe Bryant', '8')");

            Sql("INSERT INTO COURSES(CourseName, CourseDescription, TutorName, CourseRating) VALUES ('History', 'World History', 'Michael Jordan', '10')");

            Sql("INSERT INTO CourseStatus(Status) VALUES ('In-Progress')");
            Sql("INSERT INTO CourseStatus(Status) VALUES ('Completed')");
        }
        
        public override void Down()
        {
        }
    }
}
