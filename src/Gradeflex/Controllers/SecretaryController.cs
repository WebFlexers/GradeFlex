using Gradeflex.Data;
using Gradeflex.Data.Entities;
using Gradeflex.Models.Secretary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace Gradeflex.Controllers;
public class SecretaryController : Controller
{
    private readonly ILogger<SecretaryController> _logger;
    private readonly ApplicationDbContext _dbContext;
    private readonly IMemoryCache _cache;

    public SecretaryController(ILogger<SecretaryController> logger, ApplicationDbContext dbContext, IMemoryCache cache)
    {
        _logger = logger;
        _dbContext = dbContext;
        _cache = cache;
    }

    public ActionResult Profile()
    {
        try
        {
            if (_cache.TryGetValue("logged_in_user_id", out int loggedInUserId) == false)
            {
                _logger.LogWarning("Cached logged in user id was attempted to be accessed with no logged in user");
                return BadRequest("No active user found. Have you logged in?");
            }

            var secretary = _dbContext.Secretaries.FirstOrDefault(secretary => secretary.UserId.Equals(loggedInUserId));

            if (secretary == null)
            {
                var errorMessage = "The logged in user is not a secretary";
                _logger.LogWarning($"{errorMessage}. " + "User id: {id}", loggedInUserId);
                return BadRequest(errorMessage);
            }

            // Keep the id for future queries
            // _cache.Set("secretary_id", secretary.Id, TimeSpan.FromHours(5));

            return View(new SecretaryProfileViewModel
            {
                Name = secretary.Name,
                Surname = secretary.Surname,
                Department = secretary.Department,
                PhoneNumber = secretary.PhoneNumber,
            });

        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error when trying to fetch student profile from the database");
            return BadRequest("Failed to fetch profile. Try again later");
        }
    }

    public ActionResult RegisterCourse(string department)
    {
        return View(new RegisterCourseModel
        {
            Department = department
        });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult RegisterCourse(IFormCollection collection)
    {
        try
        {
            if (ModelState.IsValid == false)
            {
                _logger.LogError("Tried to register course with invalid data");
                return BadRequest("Failed to register course. Provided data was invalid");
            }

            var title = collection[nameof(RegisterCourseModel.Title)];
            var semester = collection[nameof(RegisterCourseModel.Semester)];
            var department = collection[nameof(RegisterCourseModel.Department)];

            _dbContext.Courses.Add(new Course
            {
                Title = title,
                Semester = semester,
                Department = department
            });

            _dbContext.SaveChanges();

            var message = "Successfully Registered Course";
            return RedirectToAction("SuccessMessage","Secretary", new { message });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Exception thrown when trying to register a new course");
            return BadRequest("Registration failed. Try again later");
        }
    }

    public ActionResult RegisterProfessor()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult RegisterProfessor(IFormCollection collection)
    {
        try
        {
            var afmString = collection[nameof(RegisterProfessorModel.Afm)];
            var name = collection[nameof(RegisterProfessorModel.Name)];
            var surname = collection[nameof(RegisterProfessorModel.Surname)];
            var department = collection[nameof(RegisterProfessorModel.Department)];

            var username = collection[nameof(RegisterProfessorModel.Username)];
            var password = collection[nameof(RegisterProfessorModel.Password)];

            if (ModelState.IsValid == false)
            {
                _logger.LogError("Tried to register professor with 1 or more empty values");
                return BadRequest("Failed to register professor. Some fields were invalid");
            }

            if (Int32.TryParse(afmString, out var afm) == false)
            {
                _logger.LogError("Tried to register professor with invalid afm");
                return BadRequest("Failed to register professor. Some fields were invalid");
            }

            // Run SaveChanges immediately after running to retrieve the user id
            var user = new User
            {
                Username = username,
                Password = password,
                Role = "professor"
            };

            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();

            _dbContext.Professors.Add(new Professor
            {
                Afm = afm,
                Name = name,
                Surname = surname,
                Department = department,
                UserId = user.Id,
            });

            _dbContext.SaveChanges();

            var message = "Successfully Registered Professor";
            return RedirectToAction("SuccessMessage", "Secretary", new { message });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Exception thrown when trying to register a new professor");
            return BadRequest("Registration failed. Try again later");
        }
    }

    public ActionResult RegisterStudent()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult RegisterStudent(IFormCollection collection)
    {
        try
        {
            var registrationNumberString = collection[nameof(RegisterStudentModel.RegistrationNumber)];
            var name = collection[nameof(RegisterStudentModel.Name)];
            var surname = collection[nameof(RegisterStudentModel.Surname)];
            var department = collection[nameof(RegisterStudentModel.Department)];

            var username = collection[nameof(RegisterStudentModel.Username)];
            var password = collection[nameof(RegisterStudentModel.Password)];

            if (ModelState.IsValid == false)
            {
                _logger.LogError("Tried to register student with 1 or more empty values");
                return BadRequest("Failed to register student. Some fields were invalid");
            }

            if (Int32.TryParse(registrationNumberString, out var registrationNumber) == false)
            {
                _logger.LogError("Tried to register student with invalid afm");
                return BadRequest("Failed to register student. Some fields were invalid");
            }

            // Run SaveChanges immediately after adding the user to retrieve the newly created id
            var user = new User
            {
                Username = username,
                Password = password,
                Role = "student"
            };

            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();

            _dbContext.Students.Add(new Student
            {
                RegistrationNumber = registrationNumber,
                Name = name,
                Surname = surname,
                Department = department,
                UserId = user.Id,
            });

            _dbContext.SaveChanges();

            var message = "Successfully Registered Student";
            return RedirectToAction("SuccessMessage", "Secretary", new { message });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Exception thrown when trying to register a new student");
            return BadRequest("Registration failed. Try again later");
        }
    }

    public ActionResult CoursesManagement(string department)
    {
        try
        {
            var courses = _dbContext.Courses
                .AsNoTracking()
                .Include(course => course.Professor)
                .ToList();

            Dictionary<string, List<CourseViewModel>> semesterCourses = new();

            foreach (var course in courses.OrderByDescending(c => c.Semester))
            {
                if (course.Department.Equals(department) == false)
                {
                    continue;
                }

                var courseViewModel = new CourseViewModel
                {
                    Id = course.Id,
                    Semester = course.Semester,
                    Title = course.Title,
                    Department = course.Department,
                };

                if (course.Professor != null)
                {
                    courseViewModel.ProfessorName = course.Professor.Name;
                    courseViewModel.ProfessorSurname = course.Professor.Surname;
                }

                if (semesterCourses.ContainsKey(course.Semester))
                {
                    semesterCourses[course.Semester].Add(courseViewModel);
                }
                else
                {
                    semesterCourses.Add(course.Semester, new List<CourseViewModel> { courseViewModel });
                }
            }

            return View(semesterCourses);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Exception thrown when trying to get all courses for the secretary");
            return BadRequest("Loading courses failed");
        }
    }

    public ActionResult StudentCourseDeclaration(int courseId, string department)
    {
        return View(new StudentCourseDeclarationModel
        {
            CourseId = courseId,
            Department = department
        });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult StudentCourseDeclaration(IFormCollection collection)
    {
        try
        {
            if (ModelState.IsValid == false)
            {
                _logger.LogError("Bad information request on student course declaration");
                return BadRequest("Declaring the course failed");
            }

            if (Int32.TryParse(collection[nameof(StudentCourseDeclarationModel.CourseId)],
                    out var courseId) == false ||
                Int32.TryParse(collection[nameof(StudentCourseDeclarationModel.RegistrationNumber)],
                    out var registrationNumber) == false)
            {
                _logger.LogError("Bad information request on student course declaration");
                return BadRequest("Declaring the course failed");
            }

            var department = collection[nameof(StudentCourseDeclarationModel.Department)];

            var student = _dbContext.Students
                .AsNoTracking()
                .FirstOrDefault(student => student.RegistrationNumber.Equals(registrationNumber) && 
                                           student.Department.Equals(department));

            if (student == null)
            {
                var message = "Failed to declare the course, because the student registration " +
                              $"number you provided wasn't found in the {department} department";
                return RedirectToAction("ErrorMessage", "Secretary", new { message });
            }

            var courseStudent = _dbContext.CoursesStudents
                .AsNoTracking()
                .FirstOrDefault(
                    cs => cs.CourseId.Equals(courseId) && cs.StudentId.Equals(student.Id)
                );

            if (courseStudent == null)
            {
                _dbContext.CoursesStudents.Add(new CourseStudent
                {
                    CourseId = courseId,
                    StudentId = student.Id
                });

                _dbContext.SaveChanges();

                var message = $"Successfully Declared Course for Student {student.Name} {student.Surname} " +
                              $"with Registration Number: {student.RegistrationNumber}";
                return RedirectToAction("SuccessMessage", "Secretary", new { message });
            }
            else
            {
                var message = "Failed to declare the course, because it is already declared " +
                              $"for {student.Name} {student.Surname} with registration number {student.RegistrationNumber}";
                return RedirectToAction("ErrorMessage", "Secretary", new { message });
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An exception was thrown when trying to declare course for student");
            return BadRequest("Declaring the course failed");
        }
    }

    public ActionResult ProfessorCourseAssignment(int courseId, string department)
    {
        return View(new ProfessorCourseAssignmentModel
        {
            CourseId = courseId,
            Department = department
        });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult ProfessorCourseAssignment(IFormCollection collection)
    {
        try
        {
            if (ModelState.IsValid == false)
            {
                _logger.LogError("Bad information request on professor course assignment");
                return BadRequest("Assigning the course to professor failed");
            }

            var department = collection[nameof(ProfessorCourseAssignmentModel.Department)];

            if (Int32.TryParse(collection[nameof(ProfessorCourseAssignmentModel.CourseId)],
                    out var courseId) == false ||
                Int32.TryParse(collection[nameof(ProfessorCourseAssignmentModel.Afm)],
                    out var professorAfm) == false)
            {
                _logger.LogError("Invalid course id or professor id when assigning professor to course");
                return BadRequest("Assigning the course to professor failed");
            }

            var selectedCourse = _dbContext.Courses
                .FirstOrDefault(course => course.Id.Equals(courseId));

            if (selectedCourse == null)
            {
                _logger.LogError(
                    "The given course id: {id} couldn't be matched with a course when assigning professor to course",
                    courseId
                );
                return BadRequest("Assigning the course to professor failed");
            }

            var professor = _dbContext.Professors
                .FirstOrDefault(prof => prof.Afm.Equals(professorAfm) &&
                                                 prof.Department.Equals(department));

            string message;

            if (professor == null)
            {
                message = "Failed to assign the course, because the afm " +
                          $"you provided didn't match with a professor in the {department} department";
                return RedirectToAction("ErrorMessage", "Secretary", new { message });
            }

            selectedCourse.ProfessorId = professor.Id;

            _dbContext.SaveChanges();

            message = $"Successfully Assigned Course to Professor {professor.Name} {professor.Surname} " +
                      $"with afm: {professor.Afm}";
            return RedirectToAction("SuccessMessage", "Secretary", new { message });

        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An exception was thrown while assigning a course to a professor");
            return BadRequest("Failed to assign course to professor");
        }
    }

    public ActionResult SuccessMessage(string message)
    {
        return View(nameof(SuccessMessage), message);
    }

    public ActionResult ErrorMessage(string message)
    {
        return View(nameof(ErrorMessage), message);
    }
}
