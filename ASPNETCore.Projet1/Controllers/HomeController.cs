using System.Diagnostics;

using ASPNETCore.Projet1.Models;

using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore.Projet1.Controllers;
public class HomeController : Controller
{
	private readonly ILogger<HomeController> _logger;

	public HomeController(ILogger<HomeController> logger)
	{
		_logger = logger;
	}

	public IActionResult Index()
	{
		//ViewData["cle"] = "valeur";	// <- on fait plus ca (appart pour les mots cles navigateur web ex Title)
		ViewBag.Client = "pouet"; // <- on fait ca (mais pas typé) QUE POUR LA VUE EN COURS
		TempData["message"] = "valeur"; // POUR TOUTE LA DUREE DE LA REQUETE
		return View();
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