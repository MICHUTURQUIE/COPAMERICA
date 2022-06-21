using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TP6_Raijel_Marini.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace TP6_Raijel_Marini.Controllers
{
    public class EquiposController : Controller
    {
    public IActionResult Index()
        {
        return View();
        }

    public IActionResult VerEquipos()
        {
        return View();
        }

    public IActionResult VerJugadoresEquipo(string Equipo)
        {
        return View();
        }
    }
}