using CatViewer.Models;
using CatViewer.Models.BrowseCats;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace CatViewer.Controllers;

public class BrowseCatsController : Controller
{
    public async Task<IActionResult> Index()
    {
        var cats = new List<APICat>();

        using(var client = new HttpClient())
        {
            string response = await client.GetStringAsync("https://api.thecatapi.com/v1/images/search?limit=8&api_key=live_bDXMYlT6oLqaK9Un1VMwX6tiVxaZjR0MppuZtzwijg0aLVxonuPZH2u1BKMwmkhs");
            cats = JsonSerializer.Deserialize<List<APICat>>(response);
        }

        var viewModel = new BrowseCatsIndexVm
        {
            Cats = cats
        };

        return View(viewModel);
    }
}
