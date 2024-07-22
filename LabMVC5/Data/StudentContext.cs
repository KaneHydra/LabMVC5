using Microsoft.EntityFrameworkCore;
using LabMVC5.Models;

namespace LabMVC5.Data
{

    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }
        //
        public DbSet<Student> Students { get; set; }
        //
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentID = 1,
                    StudNo = "1",
                    CName = "AAA",
                    Year = 1972,
                    Feedback = "...",
                },
                new Student
                {
                    StudentID = 2,
                    StudNo = "2",
                    CName = "BBB",
                    Year = 1972,
                    Feedback = "...",
                },
                new Student
                {
                    StudentID = 3,
                    StudNo = "3",
                    CName = "CCC",
                    Year = 1972,
                    Feedback = "...",
                },
                new Student
                {
                    StudentID = 4,
                    StudNo = "4",
                    CName = "DDD",
                    Year = 1972,
                    Feedback = "...",
                },
                new Student
                {
                    StudentID = 5,
                    StudNo = "5",
                    CName = "EEE",
                    Year = 1972,
                    Feedback = "...",
                });
        }
    }
}
