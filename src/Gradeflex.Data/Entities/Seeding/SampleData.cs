using Bogus;
using Microsoft.EntityFrameworkCore;

namespace Gradeflex.Data.Entities.Seeding;

public class SampleData
{
    //private const int StudentsNumber = 950;
    //private const int ProfessorsNumber = 20;
    //private const int SecretariesNumber = 5;

    //private const int CoursesNumber = 50;

    //// Each student will have 3 grades in each course (1 exercise, 1 assignment and 1 final exam)
    //private const int GradesNumber = StudentsNumber * CoursesNumber * 3;

    private const int StudentsNumber = 50;
    private const int ProfessorsNumber = 10;
    private const int SecretariesNumber = 5;

    private const int CoursesNumber = 10;

    // Each student will have 3 grades in each course (1 exercise, 1 assignment and 1 final exam)
    private const int GradesNumber = StudentsNumber * CoursesNumber * 3;

    private List<User> _users = new();
    private List<Student> _students = new();
    private List<Professor> _professors = new();
    private List<Secretary> _secretaries = new();

    private List<Course> _courses = new();
    private List<CourseStudent> _coursesStudents = new();

    private List<Grade> _grades = new();

    public void Seed(ModelBuilder modelBuilder)
    {
        Randomizer.Seed = new Random(8692369);

        CreateStudents();
        CreateProfessors();
        CreateSecretaries();

        modelBuilder.Entity<User>().HasData(_users);
        modelBuilder.Entity<Student>().HasData(_students);
        modelBuilder.Entity<Professor>().HasData(_professors);
        modelBuilder.Entity<Secretary>().HasData(_secretaries);
    }

    private int _userId = 1;
    private Faker<User> CreateUserFaker(string role)
    {
        return new Faker<User>()
            .RuleFor(u => u.Id, _ => _userId++)
            .RuleFor(u => u.Username, f => f.Internet.UserName())
            .RuleFor(u => u.Password, f => f.Internet.Password())
            .RuleFor(u => u.Role, role);
    }

    private readonly string[] _departments = { "Informatics", "Economics" };
    private void CreateStudents()
    {
        var userFaker = CreateUserFaker("student");
        _users.AddRange(userFaker.Generate(StudentsNumber));

        // A dictionary that stores the starting Registration Number
        // for each department, so it can be incremented later
        Dictionary<string, int> departmentStartingRns = new();
        foreach (var department in _departments)
        {
            departmentStartingRns[department] = 1900;
        }

        int studentId = 1;
        var studentFaker = new Faker<Student>()
            .CustomInstantiator(f =>
            {
                var department = f.PickRandom(_departments);

                return new Student
                {
                    Id = studentId,
                    RegistrationNumber = departmentStartingRns[department]++,
                    Name = f.Name.FirstName(),
                    Surname = f.Name.LastName(),
                    Department = department,
                    UserId = studentId++
                };
            });

        _students.AddRange(studentFaker.Generate(StudentsNumber));
    }

    private readonly int[] _possibleAfmFirstNumbers = { 1, 2, 3, 4 };
    private void CreateProfessors()
    {
        var userFaker = CreateUserFaker("professor");
        _users.AddRange(userFaker.Generate(ProfessorsNumber));

        int professorId = 1;
        int userId = StudentsNumber + 1;
        var professorFake = new Faker<Professor>()
            .CustomInstantiator(f =>
            {
                return new Professor
                {
                    Id = professorId++,
                    Afm = int.Parse(f.Random.Replace($"{f.PickRandom(_possibleAfmFirstNumbers)}########")),
                    Name = f.Name.FirstName(),
                    Surname = f.Name.LastName(),
                    Department = f.PickRandom(_departments),
                    UserId = userId++
                };
            });

        _professors.AddRange(professorFake.Generate(ProfessorsNumber));
    }

    private void CreateSecretaries()
    {
        var userFaker = CreateUserFaker("secretary");
        _users.AddRange(userFaker.Generate(SecretariesNumber));

        int secretaryId = 1;
        int userId = StudentsNumber + ProfessorsNumber + 1;
        var secretaryFake = new Faker<Secretary>()
            .CustomInstantiator(f =>
            {
                return new Secretary
                {
                    Id = secretaryId++,
                    PhoneNumber = int.Parse(f.Phone.PhoneNumber("210#######")),
                    Name = f.Name.FirstName(),
                    Surname = f.Name.LastName(),
                    Department = f.PickRandom(_departments),
                    UserId = userId++
                };
            });

        _secretaries.AddRange(secretaryFake.Generate(SecretariesNumber));
    }
}
