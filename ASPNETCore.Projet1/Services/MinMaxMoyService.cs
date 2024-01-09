using ASPNETCore.Projet1.Services.Contracts;

namespace ASPNETCore.Projet1.Services;

public class MinMaxMoyService : IMinMaxService
{
	public int ProcessNumber(int min, int max)
	{
		return (min + max) / 2;
	}
}
