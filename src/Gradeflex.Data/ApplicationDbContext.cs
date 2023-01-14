using System.Reflection;
using Gradeflex.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gradeflex.Data;

public class ApplicationDbContext : DbContext
{
    public  ApplicationDbContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Secretary> Secretaries { get; set; }
    public DbSet<Professor> Professors { get; set; }
}
