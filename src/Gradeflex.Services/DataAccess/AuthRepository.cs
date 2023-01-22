using Gradeflex.Data;
using Gradeflex.Data.Entities;

namespace Gradeflex.Services.DataAccess;

public class AuthRepository
{
    private readonly ApplicationDbContext _dbContext;

    public AuthRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Tries to find a user with the given credentials
    /// </summary>
    /// <returns> The user if found or null </returns>
    public User? Login(string username, string password)
    {
        return _dbContext.Users.FirstOrDefault(
            user => user.Username.Equals(username) && user.Password.Equals(password)
        );
    }

    /// <summary>
    /// Gets the student that corresponds to the given user
    /// </summary>
    public Student? GetStudentFromUser(User user)
    {
        if (user.Role != "student")
        {
            return null;
        }

        return _dbContext.Students.FirstOrDefault(
            student => student.UserId.Equals(user.Id)
        );
    }

    /// <summary>
    /// Gets the professor that corresponds to the given user
    /// </summary>
    public Professor? GetProfessorFromUser(User user)
    {
        if (user.Role != "professor")
        {
            return null;
        }

        return _dbContext.Professors.FirstOrDefault(
            professor => professor.UserId.Equals(user.Id)
        );
    }

    /// <summary>
    /// Gets the professor that corresponds to the given user
    /// </summary>
    public Secretary? GetSecretaryFromUser(User user)
    {
        if (user.Role != "secretary")
        {
            return null;
        }

        return _dbContext.Secretaries.FirstOrDefault(
            secretary => secretary.UserId.Equals(user.Id)
        );
    }
}
