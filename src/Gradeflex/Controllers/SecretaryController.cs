using Gradeflex.Data;
using Gradeflex.Models.Secretary;
using Microsoft.AspNetCore.Mvc;

namespace Gradeflex.Controllers;
public class SecretaryController : Controller
{
    private readonly ILogger<SecretaryController> _logger;
    private readonly ApplicationDbContext _dbContext;

    public SecretaryController(ILogger<SecretaryController> logger, ApplicationDbContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

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

    public ActionResult RegisterCourses()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult RegisterCourses(IFormCollection collection)
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

    public ActionResult RegisterProfessors()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult RegisterProfessors(IFormCollection collection)
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

    public ActionResult RegisterStudents()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult RegisterStudents(IFormCollection collection)
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
}
