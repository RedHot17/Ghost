using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ghost.Models;

namespace Ghost.Data
{
    public class GhostContext : DbContext
    {
        public GhostContext (DbContextOptions<GhostContext> options)
            : base(options)
        {
        }

        public DbSet<Ghost.Models.Student> Student { get; set; }

        public DbSet<Ghost.Models.Teacher> Teacher { get; set; }

        public DbSet<Ghost.Models.Course> Course { get; set; }

        public DbSet<Ghost.Models.Enrollment> Enrollment { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Enrollment>()
                .HasOne<Student>(p => p.Student)
                .WithMany(p => p.Enrolls)
                .HasForeignKey(p => p.StudentId);
            modelBuilder.Entity<Enrollment>()
                .HasOne<Course>(d => d.Course)
                .WithMany(d => d.Enrolls)
                .HasForeignKey(d => d.CourseId);
            modelBuilder.Entity<Course>()
                .HasOne<Teacher>(p => p.TeacherOne)
                .WithMany(p => p.Courses1)
                .HasForeignKey(p => p.FirstTeacherId);
            modelBuilder.Entity<Course>()
                .HasOne<Teacher>(p => p.TeacherTwo)
                .WithMany(p => p.Courses2)
                .HasForeignKey(p => p.SecondTeacherId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
