using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tarea_3.Models;

namespace Tarea_3.Controllers;


public class masctController : Controller
{
    public IActionResult registro()
    {
        return View();
    }

    [HttpPost]
    public IActionResult registro(masct m)
    {
        if (!ModelState.IsValid) return View();
        return View("confirmar", m);
    }
}