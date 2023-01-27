using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gradeflex.Controllers;
public class ProfessorController : Controller
{
    // GET: ProfessorController
    public ActionResult Profile()
    {
        return View();
    }

    // GET: ProfessorController/Details/5
    public ActionResult Details(int id)
    {
        return View();
    }

    // GET: ProfessorController/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: ProfessorController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Profile));
        }
        catch
        {
            return View();
        }
    }

    // GET: ProfessorController/Edit/5
    public ActionResult Edit(int id)
    {
        return View();
    }

    // POST: ProfessorController/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Profile));
        }
        catch
        {
            return View();
        }
    }

    // GET: ProfessorController/Delete/5
    public ActionResult Delete(int id)
    {
        return View();
    }

    // POST: ProfessorController/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Profile));
        }
        catch
        {
            return View();
        }
    }
}
