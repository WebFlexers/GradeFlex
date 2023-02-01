using Gradeflex.Data;
using Gradeflex.Data.Entities;
using Gradeflex.Models;
using Gradeflex.Models.Professor;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
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

    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public ActionResult Create(IFormCollection collection)
    //{
    //    try
    //    {
    //        return RedirectToAction(nameof(Profile));
    //    }
    //    catch
    //    {
    //        return View();
    //    }
    //}
}
