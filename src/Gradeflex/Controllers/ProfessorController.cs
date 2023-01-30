using Gradeflex.Data;
using Gradeflex.Models.Professor;
using Gradeflex.Models.Secretary;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

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

    public ActionResult ProfessorCoursesGrades()
    {
        return View();
    }

    public ActionResult GradeStudents()
    {
        return View();
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
