using ASPNETCore.Projet1.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace ASPNETCore.Projet1.Controllers;
public class Exo2MessageController : Controller
{
	/*
	 * Exo 2 Faire une classe modèle de type Message (Emetteur, Contenu et Date)
	 * 
		7. Faire une page contenant un formulaire qui envoi des informations à un contrôleur en POST

		8. Faire une page contenant un formulaire fortement typé (type Message) qui envoi le model à un contrôleur en POST

		9. Faire une page fortement typé Message qui affiche un message

		10. Faire une page fortement typé liste de Message qui affiche une liste de messages

		11. Faire l’envoi en post d’une liste de string

		12. Faire l’envoi en post d’une liste de Message

		13. Faire un lien HTML qui envoi des informations à un contrôleur en GET
	*/


	public IActionResult Index(Message? message, string sender = "no one", string body = "placeholder")
	{
		return View();
	}


	/// <summary>
	/// 7. Faire une page contenant un formulaire qui envoi des informations à un contrôleur en POST
	/// </summary>
	/// <returns></returns>
	public IActionResult EnvoiFormNonType()
	{
		return View();
	}


	/// <summary>
	/// 8. Faire une page contenant un formulaire fortement typé (type Message) qui envoi le model à un contrôleur en POST
	/// </summary>
	/// <returns></returns>
	public IActionResult EnvoiFormFortementType()
	{
		return View();
	}


	/// <summary>
	/// 9. Faire une page fortement typé Message qui affiche un message
	/// </summary>
	/// <returns></returns>
	public IActionResult AffichageMessage()
	{
		Message message = new Message() 
		{
			Sender = "sent form code",
			Body = "generated body",
			Date = DateTime.Now
		};

		return View(message);
	}


	/// <summary>
	/// 10. Faire une page fortement typé liste de Message qui affiche une liste de messages
	/// </summary>
	/// <returns></returns>
	public IActionResult AffichageListeMessages()
	{
		List<Message> messageList = new List<Message>()
		{
			new()
			{
				Sender = "sent form code 1",
				Body = "generated body",
				Date = DateTime.Now
			},
			new()
			{
				Sender = "sent form code 2",
				Body = "generated body",
				Date = DateTime.Now
			},
			new()
			{
				Sender = "sent form code 3",
				Body = "generated body",
				Date = DateTime.Now
			}
		};

		return View(messageList);
	}


	/// <summary>
	/// 11. Faire l’envoi en post d’une liste de string
	/// </summary>
	/// <returns></returns>
	[HttpGet]
	public IActionResult EnvoiListeString()	// appele en premier
	{
		return View(); // redirige vers la vue formulaire
	}
	[HttpPost]
	public IActionResult EnvoiListeString(List<String> strings)	// appele en deuxieme depuis la vue du formulaire
	{
		strings.ForEach(Console.WriteLine);

        return RedirectToAction("Index");
	}


	/// <summary>
	/// 12. Faire l’envoi en post d’une liste de Message
	/// </summary>
	/// <returns></returns>
	[HttpGet]
	public IActionResult EnvoiListeMessages()
	{


		return View();
	}
	[HttpPost]
	public IActionResult EnvoiListeMessages(List<Message> messages)
	{
		return RedirectToAction("AffichageListeMessages");
	}


	/// <summary>
	/// 13. Faire un lien HTML qui envoi des informations à un contrôleur en GET
	/// </summary>
	/// <param name="sender"></param>
	/// <returns></returns>
	public IActionResult DetailMessage(string sender)
	{
		Message message = new Message()
		{
			Sender = sender,
			Body = "body genere apres detail",
			Date = DateTime.Now
		};

		return View(message);
	}
}
