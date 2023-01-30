using System.Text.RegularExpressions;
using Gradeflex.Data;
using Gradeflex.Data.Entities;
using Gradeflex.Models.Secretary;
using Microsoft.AspNetCore.Mvc;
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
            int loggedInUserId;

            if (_cache.TryGetValue("logged_in_user_id", out loggedInUserId) == false)
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

            return View(new SecretaryProfileModel
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

    public ActionResult RegisterCourse()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult RegisterCourse(IFormCollection collection)
    {
        try
        {
            var title = collection["Title"];
            var semester = collection["Semester"];

            if (string.IsNullOrEmpty(title))
            {
                _logger.LogError("Tried to register course with empty title");
                return BadRequest("Failed to register course. Title can't be null");
            }

            if (string.IsNullOrEmpty(semester))
            {
                _logger.LogError("Tried to register course with empty semester");
                return BadRequest("Failed to register course. Semester can't be null");
            }

            _dbContext.Courses.Add(new Course
            {
                Title = title,
                Semester = semester
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

            int afm;
            if (Int32.TryParse(afmString, out afm) == false)
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
            return RedirectToAction();
        }
        catch
        {
            return View();
        }
    }

    public ActionResult CoursesManagement()
    {
        return View();
    }

    public ActionResult SuccessMessage(string message)
    {
        return View(nameof(SuccessMessage), message);
    }
}
