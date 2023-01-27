using Gradeflex.Data;

namespace Gradeflex.Services.DataAccess;

public class StudentRepository
{
    private readonly ApplicationDbContext _dbContext;

    public StudentRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    
}
