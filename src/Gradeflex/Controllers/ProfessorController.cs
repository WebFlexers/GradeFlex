using Gradeflex.Data;
using Gradeflex.Data.Entities;
using Gradeflex.Models;
using Gradeflex.Models.Professor;
using Gradeflex.Models.Student;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics;
using CourseViewModel = Gradeflex.Models.Professor.CourseViewModel;

namespace Gradeflex.Controllers;
public class ProfessorController : Controller
{
    private readonly ILogger<ProfessorController> _logger;
    private readonly ApplicationDbContext _dbContext;
    private readonly IMemoryCache _cache;

    public ProfessorController(ILogger<ProfessorController> logger, ApplicationDbContext dbContext, IMemoryCache cache)
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

            var professor = _dbContext.Professors.FirstOrDefault(prof => prof.UserId.Equals(loggedInUserId));

            if (professor == null)
            {
                var errorMessage = "The logged in user is not a professor";
                _logger.LogWarning($"{errorMessage}. " + "User id: {id}", loggedInUserId);
                return BadRequest(errorMessage);
            }

            // Keep the id for future queries
            // _cache.Set("secretary_id", secretary.Id, TimeSpan.FromHours(5));

            return View(new ProfessorViewModel
            {
                Id = professor.Id,
                Name = professor.Name,
                Surname = professor.Surname,
                Department = professor.Department,
                Afm = professor.Afm,
            });

        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error when trying to fetch student profile from the database");
            return BadRequest("Failed to fetch profile. Try again later");
        }
    }

    public ActionResult GradedCourses(int professorId)
    {
        try
        {
            var professorGradedCourses = _dbContext.Courses
                .Where(course => course.ProfessorId == professorId && course.Grades.Any())
                .Select(course => new CourseViewModel
                {
                    Id = course.Id,
                    Title = course.Title,
                    Semester = course.Semester,
                })
                .GroupBy(course => course.Semester)
                .ToDictionary(group => group.Key,
                group => group.ToList()
            ).Reverse().ToDictionary(x => x.Key, x => x.Value);

            return View(professorGradedCourses);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An exception was thrown when trying to fetch courses graded by a professor");
            return BadRequest("Failed to fetch courses graded by the professor");
        }
    }

    public ActionResult DetailedCourseGrades(int courseId)
    {
        try
        {
            var studentsWithGradesInCourse = _dbContext.Students
                .AsNoTracking()
                .Where(student => student.Grades.Any(grade => grade.CourseId.Equals(courseId)))
                .Select(student => new StudentGradesViewModel
                {
                    RegistrationNumber = student.RegistrationNumber,
                    Name = student.Name,
                    Surname = student.Surname,
                    Grades = student.Grades.Where(grade => grade.CourseId.Equals(courseId))
                        .Select(grade => new GradeViewModel
                        {
                            Type = grade.Type,
                            Value = grade.Value
                        }).ToList()
                }).ToList();

            return View(studentsWithGradesInCourse);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An exception was thrown when trying to fetch the grades for course with id: {id}", courseId);
            return BadRequest("Failed to fetch grades");
        }
    }

    public ActionResult UngradedCourses(int professorId)
    {
        try
        {
            var coursesWithUngradedStudents = _dbContext.CoursesStudents
                .AsNoTracking()
                .Where(cs =>
                    cs.Course.ProfessorId.Equals(professorId) &&
                    cs.Student.Grades.Any(grade => grade.CourseId.Equals(cs.CourseId)) == false
                )
                .Select(cs => new CourseViewModel
                {
                    Id = cs.CourseId,
                    Semester = cs.Course.Semester,
                    Title = cs.Course.Title,
                })
                .GroupBy(courseVm => courseVm.Semester)
                .ToDictionary(group => group.Key, group => group.ToList());

            return View(coursesWithUngradedStudents);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An exception was thrown when trying to fetch ungraded " +
                                 "courses of professor with id: {id}", professorId);
            return BadRequest("Failed to fetch ungraded courses");
        }
    }

    public ActionResult CourseUngradedStudents(int courseId)
    {
        try
        {
            var ungradedStudents = _dbContext.Students
                .AsNoTracking()
                .Where(student => student.CoursesStudents.Any(cs => 
                                      cs.CourseId.Equals(courseId) && 
                                      cs.StudentId.Equals(student.Id)) 
                                  && student.Grades.Any(grade => grade.CourseId.Equals(courseId)) == false 
                                  
                )
                .Select(student => new StudentViewModel
                {
                    StudentId = student.Id,
                    CourseId = courseId,
                    RegistrationNumber = student.RegistrationNumber,
                    Name = student.Name,
                    Surname = student.Surname,
                    Department = student.Department,
                }).ToList();


            return View(ungradedStudents);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An exception was thrown when trying to fetch the ungraded " +
                                 "students of course with id: {id}", courseId);
            return BadRequest("Failed to fetch ungraded students");
        }
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult GradeStudent(IFormCollection collection)
    {
        var gradeTypes = new List<GradeType>();
        var grades = new List<double>();

        var formGradeTypes = collection["grade-types"];
        var formGrades = collection["grade"];

        if (formGrades.Count != formGradeTypes.Count)
        {
            _logger.LogError("Grades count was {gc}, but grade types count was {gtc}", formGrades.Count, formGradeTypes.Count);
            return BadRequest();
        }

        foreach (var grade in formGrades)
        {
            if (double.TryParse(new ReadOnlySpan<char>(grade.ToCharArray()), out double gradeDouble) == false)
            {
                _logger.LogError("Grade was invalid", grade);
                return BadRequest();
            }
            grades.Add(gradeDouble);
        }

        foreach (var gradeType in formGradeTypes)
        {
            if (Enum.TryParse<GradeType>(gradeType, out GradeType gradeTypeEnum) == false)
            {
                _logger.LogError("Grade type was invalid", gradeType);
                return BadRequest();
            }
            gradeTypes.Add(gradeTypeEnum);
        }

        var courseIdIsValid = int.TryParse(collection["courseId"], out int courseId);
        var studentIdIsValid = int.TryParse(collection["studentId"], out int studentId);

        if (courseIdIsValid == false || studentIdIsValid == false)
        {
            _logger.LogError("Either course or student id where invalid", courseId, studentId);
            return BadRequest();
        }

        try
        {
            for (int i = 0; i < grades.Count; i++)
            {
                _dbContext.Grades.Add(new Grade
                {
                    StudentId = studentId,
                    CourseId = courseId,
                    Type = gradeTypes[i],
                    Value = grades[i]
                });
            }

            _dbContext.SaveChanges();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to add grades");
            return BadRequest("Failed to add grades");
        }

        return RedirectToAction("Profile", "Professor");
    }
}
