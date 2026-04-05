using Microsoft.EntityFrameworkCore;
using EFAssignment2.Entities;

namespace EFAssignment2.DataBase
{
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Student)
                .WithMany(e => e.Enrollments)
                .HasForeignKey(e => e.StudentId);

            modelBuilder.Entity<Enrollment>()
                .HasOne(e => e.Course)
                .WithMany(e => e.Enrollments)
                .HasForeignKey(e => e.CourseId);

            // Seeding Data
            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, Name = "Alice Johnson", Email = "alice@example.com" },
                new Student { StudentId = 2, Name = "Bob Smith", Email = "bob@example.com" }
            );

            modelBuilder.Entity<Course>().HasData(
                new Course { CourseId = 101, Credits = 3 },
                new Course { CourseId = 102, Credits = 4 }
            );

            modelBuilder.Entity<Enrollment>().HasData(
                new Enrollment { EnrollmentId = 1, StudentId = 1, CourseId = 101 },
                new Enrollment { EnrollmentId = 2, StudentId = 2, CourseId = 102 },
                new Enrollment { EnrollmentId = 3, StudentId = 1, CourseId = 102 }
            );
        }
    }
}

