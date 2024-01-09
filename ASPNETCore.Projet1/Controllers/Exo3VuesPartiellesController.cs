using ASPNETCore.Projet1.Services;
using ASPNETCore.Projet1.Services.Contracts;

using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore.Projet1.Controllers;
public class Exo3VuesPartiellesController : Controller
{
	//// Injection de dependance COUPLAGE FORT A LA COMPILATION SANS INTERFACE
	//private readonly MinMaxRandService _minMaxRandService;
 //   public Exo3VuesPartiellesController(MinMaxRandService minMaxRandService) : this((IMinMaxRandService)minMaxRandService)
 //   { 
 //       _minMaxRandService = minMaxRandService;
 //   }

	//// Injection de dependance COUPLAGE FORT A L'EXECUTION AVEC INTERFACE
	//private readonly IMinMaxRandService _iMinMaxRandService;
 //   public Exo3VuesPartiellesController(IMinMaxRandService iMinMaxRandService)
 //   {
	//	_minMaxRandService = (MinMaxRandService)iMinMaxRandService;
 //       _iMinMaxRandService = iMinMaxRandService;
 //   }


	// INJECTION DE DEPENDANCE de mon service
	private readonly IMinMaxService _minMaxService;
	public Exo3VuesPartiellesController(IMinMaxService minMaxService)
	{
		_minMaxService = minMaxService;
	}



	/*
		Faire une vue partielle qui affiche un Message
		• Faire une vue qui affiche une liste de Messages en utilisant la vue partielle
		• Faire un ViewComponent qui prend en paramètre un Min et Max et qui retourne une
		vue qui affiche le min, max et un nombre aléatoire entre ce min et max
		• Créer un service qui retourne un random en fonction d’un min et max et utiliser ce service
		dans une action puis dans une vue
		• Grâce à un middleware redirigez l’utilisateur vers une page 404 personnalisée
	 */

	public IActionResult Index()
	{
		return View();
	}


	public IActionResult AfficherRandom()
	{
		// C'est pas fou car pas de style qui découle du layout
		// Mieux vaut appeler depuis une vue
		return ViewComponent("MinMaxRand", new { min = 0, max = 100 });
	}

	public IActionResult UtiliserServiceDepuisAction()
	{
		int min = 5;
		int max = 40;

		ViewBag.Min = min;
		ViewBag.Max = max;

		return View(_minMaxService.ProcessNumber(min, max));
	}
}
