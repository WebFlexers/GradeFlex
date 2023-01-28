using System.Runtime.InteropServices;
using Bogus;
using Gradeflex.Data;
using Gradeflex.Data.Entities;
using Gradeflex.Models.Student;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace Gradeflex.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;
    private readonly ApplicationDbContext _dbContext;
    private readonly IMemoryCache _cache;

    public StudentController(ILogger<StudentController> logger, ApplicationDbContext dbContext, IMemoryCache cache)
    {
        _logger = logger;
        _dbContext = dbContext;
        _cache = cache;
    }

    // GET: StudentController
    public ActionResult Profile()
    {
        try
        {
            if (TempData.ContainsKey("logged_in_user_id") == false)
            {
                _logger.LogWarning("TempData was accessed with no logged in user");
                return BadRequest("No active user found. Have you logged in?");
            }

            int loggedInUserId = (int)TempData["logged_in_user_id"]!;
            var student = _dbContext.Students.FirstOrDefault(student => student.UserId.Equals(loggedInUserId));

            if (student == null)
            {
                var errorMessage = "The logged in user is not a student";
                _logger.LogWarning($"{errorMessage}. " + "User id: {id}", loggedInUserId);
                return BadRequest(errorMessage);
            }

            // Keep the id for future queries
            _cache.Set("student_id", student.Id, TimeSpan.FromHours(5));

            return View(new StudentProfileModel
            {
                Name = student.Name,
                Surname = student.Surname,
                Department = student.Department,
                RegistrationNumber = student.RegistrationNumber,
            });

        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error when trying to fetch student profile from the database");
            return BadRequest("Failed to fetch profile. Try again later");
        }
    }

    public ActionResult AllGrades()
    {
        Dictionary<string, List<CourseModel>> coursesBySemester = new();

        try
        {
            int studentId;

            if (_cache.TryGetValue("student_id", out studentId) == false)
            {
                _logger.LogError("student_id not found when trying to get courses and their grades for the logged in user");
                return BadRequest("Something went wrong. Try to log in again");
            }

            var studentCourses = _dbContext.CoursesStudents.AsNoTracking()
                .Where(cs => cs.StudentId.Equals(studentId))
                .Include(cs => cs.Course)
                .Select(cs => cs.Course)
                .ToList();

            if (studentCourses.Any() == false)
            {
                return View(coursesBySemester);
            }

            var studentGrades = _dbContext.Grades.AsNoTracking()
                .Where(grade => grade.StudentId.Equals(studentId))
                .ToList();

            foreach (var course in studentCourses.OrderByDescending(c => c.Semester))
            {
                List<GradeModel> allGrades = new();
                double finalGrade = 0;

                if (studentGrades.Any())
                {
                    allGrades = studentGrades.Where(grade => grade.CourseId.Equals(course.Id))
                        .Select(grade => new GradeModel
                        {
                            Value = grade.Value,
                            Type = grade.Type,
                        }).ToList();

                    // To calculate the final grade we need to take into consideration
                    // all the grades of the student in the specific course as well as their
                    // importance. Exercises count as 1, assignments as 3 and the final exam as 6
                    int totalGradesToDivideBy = 0;

                    foreach (var grade in CollectionsMarshal.AsSpan(allGrades))
                    {
                        switch (grade.Type)
                        {
                            case GradeType.ExerciseGrade:
                                totalGradesToDivideBy += 1;
                                finalGrade += grade.Value;
                                break;
                            case GradeType.AssignmentGrade:
                                totalGradesToDivideBy += 3;
                                finalGrade += grade.Value * 3;
                                break;
                            case GradeType.FinalExamGrade:
                                totalGradesToDivideBy += 6;
                                finalGrade += grade.Value * 6;
                                break;
                        }
                    }

                    finalGrade /= totalGradesToDivideBy;
                }

                var courseModel = new CourseModel
                {
                    Title = course.Title,
                    Semester = course.Semester,
                    AllGrades = allGrades,
                    FinalGrade = finalGrade,
                };

                if (coursesBySemester.ContainsKey(courseModel.Semester))
                {
                    coursesBySemester[courseModel.Semester].Add(courseModel);
                }
                else
                {
                    coursesBySemester.Add(courseModel.Semester, new List<CourseModel> { courseModel });
                }
            }

            return View(coursesBySemester);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An exception was thrown when trying to load the students grades for courses");
            return BadRequest("An error occurred when trying to load the students grades for courses");
        }
    }

    public ActionResult SingleGrade(string courseName)
    {
        return View();
    }
}
