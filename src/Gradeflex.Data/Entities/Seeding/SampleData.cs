using Bogus;
using Microsoft.EntityFrameworkCore;

namespace Gradeflex.Data.Entities.Seeding;

public class SampleData
{
    private const int StudentsNumber = 50;
    private const int ProfessorsNumber = 10;
    private const int SecretariesNumber = 5;

    // Don't change the ProfessorsNumber * 2, because it will brake the courses generation
    private const int CoursesNumber = ProfessorsNumber * 2;

    // Each student will have 3 grades in each course (1 exercise, 1 assignment and 1 final exam)
    private const int GradesNumber = StudentsNumber * CoursesNumber * 3;

    private readonly List<User> _users = new();
    private readonly List<Student> _students = new();
    private readonly List<Professor> _professors = new();
    private readonly List<Secretary> _secretaries = new();

    private readonly List<Course> _courses = new();
    private readonly List<CourseStudent> _coursesStudents = new();

    private List<Grade> _grades = new();

    public void Seed(ModelBuilder modelBuilder)
    {
        //if (System.Diagnostics.Debugger.IsAttached == false)
        //{
        //    System.Diagnostics.Debugger.Launch();
        //}

        Randomizer.Seed = new Random(8692369);

        CreateStudents();
        CreateProfessors();
        CreateSecretaries();
        CreateCourses();
        CreateCoursesStudents();
        CreateGrades();

        modelBuilder.Entity<User>().HasData(_users);
        modelBuilder.Entity<Student>().HasData(_students);
        modelBuilder.Entity<Professor>().HasData(_professors);
        modelBuilder.Entity<Secretary>().HasData(_secretaries);
        modelBuilder.Entity<Course>().HasData(_courses);
        modelBuilder.Entity<CourseStudent>().HasData(_coursesStudents);
        modelBuilder.Entity<Grade>().HasData(_grades);
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

    private readonly Dictionary<int, string> _studentsDepartments = new();
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
            departmentStartingRns[department] = 19000;
        }

        int studentId = 1;
        var studentFaker = new Faker<Student>()
            .CustomInstantiator(f =>
            {
                var department = f.PickRandom(_departments);
                _studentsDepartments.Add(studentId, department);

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

    // This list will be used later to add the correct courses to professors
    private readonly List<string> _professorsDepartments = new();
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
                var department = f.PickRandom(_departments);
                _professorsDepartments.Add(department);

                return new Professor
                {
                    Id = professorId++,
                    Afm = int.Parse(f.Random.Replace($"{f.PickRandom(_possibleAfmFirstNumbers)}########")),
                    Name = f.Name.FirstName(),
                    Surname = f.Name.LastName(),
                    Department = department,
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

    private readonly List<string> _informaticsCourses = new()
    {
        "Introduction to bioinformatics", "Analysis of biological sequences and structures", "Introduction to programming",
        "Object-oriented programming", "Algorithms, Data Structures and Programming", "Introduction to Systems Development",
        "Introduction to operating Systems", "Databases and modeling", "Functional Programming", "Computer Networks",
        "Introduction to Cybersecurity", "Applied Cryptography", "Modeling and Optimization", "Social Networks Theory",
        "Modelling of Computing", "Concurrent programming", "Advanced functional programming", "Category Theory",
        "Software Security", "Complexity Theory", "Algorithms Engineering"
    };
    private readonly List<string> _economicsCourses = new()
    {
        "Introduction to Economic Analysis","Statistics","Economic History","Introduction to Economic Analysis ΙΙ","Statistics ΙΙ",
        "Mathematics for Economists Ι","Principles of Financial Accounting","Microeconomic Theory","Macroeconomic Theory","Introduction to Econometrics",
    };

    private readonly List<(int, string)> _coursesDepartments = new();
    private void CreateCourses()
    {
        int count = 0;
        int professorId = 0;
        int courseId = 1;
        var coursesFake = new Faker<Course>()
            .CustomInstantiator(f =>
            {
                // This is done to assign 2 courses to each professor
                // instead of one
                if (count % 2 == 0)
                {
                    professorId++;
                }

                string title;
                string department;
                if (_professorsDepartments[professorId - 1] == "Informatics")
                {
                    title = f.PickRandom(_informaticsCourses);
                    department = "Informatics";
                    _coursesDepartments.Add((courseId, "Informatics"));
                    _informaticsCourses.Remove(title);
                }
                else
                {
                    title = f.PickRandom(_economicsCourses);
                    department = "Economics";
                    _coursesDepartments.Add((courseId, "Economics"));
                    _economicsCourses.Remove(title);
                }

                count++;

                return new Course
                {
                    Id = courseId++,
                    Title = title,
                    Department = department,
                    Semester = f.Random.Number(1, 8).ToString(),
                    ProfessorId = professorId
                };
            });

        _courses.AddRange(coursesFake.Generate(CoursesNumber));
    }

    private readonly List<(int, int)> _studentsCourses = new();
    private void CreateCoursesStudents()
    {
        // List used to keep track of the students and courses
        // in order to avoid duplicates
        
        int studentId = 0;
        var coursesStudentsFake = new Faker<CourseStudent>()
            .CustomInstantiator(f =>
            {
                studentId++;

                if (studentId == StudentsNumber)
                {
                    studentId = 1;
                }

                int courseId;
                while (true)
                {
                    courseId = f.Random.Number(1, CoursesNumber);

                    // If the specific student and course have already been added get a new value
                    if (_studentsCourses.Exists(cs => cs.Item1 == studentId && cs.Item2 == courseId))
                    {
                        continue;
                    }

                    // If the student and the course are in different departments get a new value
                    var studentDepartment = _studentsDepartments[studentId];
                    var courseDepartment = _coursesDepartments.FirstOrDefault(
                        cd => cd.Item1 == courseId);
                    if (courseDepartment.Item2 != studentDepartment)
                    {
                        continue;
                    }

                    break;
                }

                _studentsCourses.Add((studentId, courseId));

                return new CourseStudent
                {
                    StudentId = studentId,
                    CourseId = courseId
                };
            });

        _coursesStudents.AddRange(coursesStudentsFake.Generate(StudentsNumber * 3));
    }

    private void CreateGrades()
    {
        int courseStudentIndex = -1;
        int gradeId = 0;

        var gradesFake = new Faker<Grade>()
            .CustomInstantiator(f =>
            {
                if (gradeId % 3 == 0)
                {
                    courseStudentIndex++;
                }

                gradeId++;

                var courseStudent = _coursesStudents[courseStudentIndex];

                int gradeValue = f.Random.Number(0, 15);

                if (gradeValue > 10)
                {
                    gradeValue -= 5;
                }

                return new Grade
                {
                    Id = gradeId,
                    Value = gradeValue,
                    Type = (GradeType)(gradeId % 3),
                    CourseId = courseStudent.CourseId,
                    StudentId = courseStudent.StudentId,
                };
            });

        _grades.AddRange(gradesFake.Generate(_coursesStudents.Count * 3));
    }
}
