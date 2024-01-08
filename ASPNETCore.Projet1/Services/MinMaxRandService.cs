using System.Security.Cryptography;

namespace ASPNETCore.Projet1.Services;

public class MinMaxRandService
{
	public int GetRandomNumber(int min, int max)
	{
		return RandomNumberGenerator.GetInt32(min, max + 1);
	}
}
