using Gradeflex.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Gradeflex.Data;
using Gradeflex.Data.Entities;

namespace Gradeflex.Controllers;

public class LoginController : Controller
{
    private readonly ILogger<LoginController> _logger;
    private readonly ApplicationDbContext _dbContext;

    public LoginController(ILogger<LoginController> logger, ApplicationDbContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
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
            User? user = _dbContext.Users.FirstOrDefault(user =>
                user.Username.Equals(collection["Username"]) &&
                user.Password.Equals(collection["Password"])
            );

            if (user == null)
            {
                ModelState.AddModelError("wrong_credentials", "Invalid username or password");
                return View();
            }

            switch (user.Role)
            {
                case "student":
                    return RedirectToAction("Profile", "Student");
                case "professor":
                    return RedirectToAction("Profile", "Professor");
                case "secretary":
                    return RedirectToAction("Profile", "Secretary");
            }

            return View();
        }
        catch
        {
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
