using System.Reflection;
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
}
