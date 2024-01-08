using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore.Projet1.ViewComponents;

public class MinMaxRandViewComponent : ViewComponent
{
    public async Task<IViewComponentResult> InvokeAsync(int min, int max)
    {
        int monRandom = RandomNumberGenerator.GetInt32(min, max + 1);

        return View(/*"Default", */new { min, max, monRandom });
    }
}
