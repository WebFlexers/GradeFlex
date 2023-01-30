using Gradeflex.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Gradeflex.Data;
using Gradeflex.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace Gradeflex.Controllers;

public class LoginController : Controller
{
    private readonly ILogger<LoginController> _logger;
    private readonly ApplicationDbContext _dbContext;
    private readonly IMemoryCache _cache;

    public LoginController(ILogger<LoginController> logger, ApplicationDbContext dbContext, IMemoryCache cache)
    {
        _logger = logger;
        _dbContext = dbContext;
        _cache = cache;
    }

    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Login(IFormCollection collection)
    {
        try
        {
            User? user = _dbContext.Users
                .AsNoTracking()
                .FirstOrDefault(user =>
                    user.Username.Equals(collection["Username"]) &&
                    user.Password.Equals(collection["Password"])
                );

            if (user == null)
            {
                ModelState.AddModelError("wrong_credentials", "Invalid username or password");
                _logger.LogWarning("User tried to login with wrong credentials");
                return View();
            }

            // Used to query upon the logged in user in other controllers
            _cache.Set("logged_in_user_id", user.Id, TimeSpan.FromHours(5));

            switch (user.Role)
            {
                case "student":
                    _logger.LogInformation("Student with username '{1}' logged in", user.Username);
                    return RedirectToAction("Profile", "Student");
                case "professor":
                    _logger.LogInformation("Professor with username '{1}' logged in", user.Username);
                    return RedirectToAction("Profile", "Professor");
                case "secretary":
                    _logger.LogInformation("Secretary with username '{1}' logged in", user.Username);
                    return RedirectToAction("Profile", "Secretary");
            }

            return View();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex,"Exception occurred when trying to log in");
            return View();
        }
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
