using System.Reflection;
using Gradeflex.Data.Entities;
using Gradeflex.Data.Entities.Seeding;
using Microsoft.EntityFrameworkCore;

namespace Gradeflex.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        new SampleData().Seed(modelBuilder);
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Secretary> Secretaries { get; set; }
    public DbSet<Professor> Professors { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<CourseStudent> CoursesStudents { get; set; }
    public DbSet<Grade> Grades { get; set; }
}
