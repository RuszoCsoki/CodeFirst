using ConsoleApp1;
using EF6Console;
using System.Data.Entity;


using (var ctx = new SchoolContext())
{
    var grds = new Grade() { GradeName = "A", GradeId = 1, Section = "85+" };
    var stud = new Student() { StudentID = 101 ,StudentName = "Bill Bow" , Height = 6 };


    ctx.Students.Add(stud);
    ctx.SaveChanges();
    Console.WriteLine(stud.StudentName+ " " + stud.StudentID);
    Console.WriteLine();
}

namespace EF6Console
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base()
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}