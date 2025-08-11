using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Tarea_3.Models;

namespace Tarea_3.Controllers
{
    public class ProductosController : Controller
    {
         public IActionResult Lista()
        {
            var lista = new List<producto>
            {
                new producto { nom = "Collar", tipo = "Accesorio", prec = 15.50m },
                new producto { nom = "Comida Perro", tipo = "Alimento", prec = 25.00m },
                new producto { nom = "Pelota", tipo = "Juguete", prec = 8.75m }
            };

            return View(lista);
        }
    }
}