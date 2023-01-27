﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gradeflex.Controllers;

public class StudentController : Controller
{
    // GET: StudentController
    public ActionResult Profile()
    {
        return View();
    }

    // GET: StudentController/Details/5
    public ActionResult Details(int id)
    {
        return View();
    }

    // GET: StudentController/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: StudentController/Create
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

    // GET: StudentController/Edit/5
    public ActionResult Edit(int id)
    {
        return View();
    }

    // POST: StudentController/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: StudentController/Delete/5
    public ActionResult Delete(int id)
    {
        return View();
    }

    // POST: StudentController/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }
}
