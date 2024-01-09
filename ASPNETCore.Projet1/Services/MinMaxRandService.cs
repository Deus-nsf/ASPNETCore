using System.Security.Cryptography;
using ASPNETCore.Projet1.Services.Contracts;

namespace ASPNETCore.Projet1.Services;

public class MinMaxRandService : IMinMaxService
{
	public int ProcessNumber(int min, int max)
	{
		return RandomNumberGenerator.GetInt32(min, max + 1);
	}
}
