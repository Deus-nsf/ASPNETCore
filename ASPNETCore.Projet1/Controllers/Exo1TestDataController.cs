using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore.Projet1.Controllers;
public class Exo1TestDataController : Controller
{
	public IActionResult Index() { return View(); }

	public IActionResult TestData1()
	{
		ViewBag.TestKey = "Valeur du ViewBag";
		TempData["TestKey"] = "Valeur du TempData";

		int entier = 10;

		string maChaine = $"Mon message est : {entier}";

		return View();
	}

	public IActionResult TestData2()
	{
		return View();
	}

	public IActionResult TestData3()
	{
		ViewBag.TestKey = "Valeur du ViewBag";
		TempData["TestKey"] = "Valeur du TempData";


		return RedirectToAction(nameof(TestData2));
	}

	public IActionResult TestData4()
	{
		ViewBag.TestKey = "Valeur du ViewBag avec bypass de l'action de la vue qu'on appelle (mauvaise pratique)";
		TempData["TestKey"] = "Valeur du TempData avec bypass de l'action de la vue qu'on appelle (mauvaise pratique)";

		return View(nameof(TestData1));
	}
}
