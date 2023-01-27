using Gradeflex.Data;
using Gradeflex.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Gradeflex.Models.Student;

namespace Gradeflex.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;
    private readonly ApplicationDbContext _dbContext;

    public StudentController(ILogger<StudentController> logger, ApplicationDbContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

    // GET: StudentController
    public ActionResult Profile()
    {
        try
        {
            int loggedInUserId = (int)TempData["logged_in_user_id"]!;
            var student = _dbContext.Students.FirstOrDefault(student => student.UserId.Equals(loggedInUserId));

            if (student != null)
            {
                return View(new StudentModel
                {
                    Name = student.Name,
                    Surname = student.Surname,
                    Department = student.Department,
                    RegistrationNumber = student.RegistrationNumber,
                });
            }
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error when trying to fetch student profile from the database");
            return BadRequest("Failed to fetch profile. Try again later");
        }

        return BadRequest();
    }
}
