using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore.Projet1.Controllers;
public class Exo3VuesPartiellesController : Controller
{
	// CONTROLLEUR PAS UTILE

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
}
