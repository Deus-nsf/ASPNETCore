using System.Security.Cryptography;

using ASPNETCore.Projet1.ViewModels;

using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore.Projet1.ViewComponents;

public class MinMaxRandViewComponent : ViewComponent
{
	public async Task<IViewComponentResult> InvokeAsync(int min, int max)
	{
		int monRandom = RandomNumberGenerator.GetInt32(min, max + 1);

		MinMaxRandViewModel minMaxRandViewModel =
			new MinMaxRandViewModel()
			{
				Min = min,
				Max = max,
				MonRandom = monRandom
			};

		return View("Default", minMaxRandViewModel);
	}
}
