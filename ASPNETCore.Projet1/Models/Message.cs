namespace ASPNETCore.Projet1.Models;


public class Message
{
    public string? Sender { get; set; }
    public string? Body { get; set; }
    public DateTime? Date { get; set; }


	public override string ToString()
	{
		string formattedMessage = 
			$"Sender : {Sender}\n" +
			$"Body : {Body}\n" +
			$"Date : {Date}\n";

		return formattedMessage;
	}
}
