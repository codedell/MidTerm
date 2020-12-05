namespace DellMT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCourses : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Courses(CourseName, CourseDescription, TutorName, CourseRating) VALUES ('Math', 'College Math', 'Mike Jones', 1)");

            Sql("INSERT INTO Courses(CourseName, CourseDescription, TutorName, CourseRating) VALUES ('Science', 'College Science', 'Lisa Leslie', 2)");

            Sql("INSERT INTO Courses(CourseName, CourseDescription, TutorName, CourseRating) VALUES ('Programming', 'C#', 'Jerry Rice', 1)");

            Sql("INSERT INTO Courses(CourseName, CourseDescription, TutorName, CourseRating) VALUES ('History', 'College History', 'Betty Crocker', 2)");
        }
        
        public override void Down()
        {
        }
    }
}
