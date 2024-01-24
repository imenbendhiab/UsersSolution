using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using UsersAppClient.Models;

namespace UsersAppClient.Controllers
{
    public class UsersClientsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> GetAllUsers()
        {
            HttpClient client = new();
            client.BaseAddress = new Uri("https://localhost:7214");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json")
                );
            HttpResponseMessage response = await client.GetAsync(
                 "api/Users/Get-All-Users"
                 );
            if (response.IsSuccessStatusCode)
            {
                var users = await response.Content.ReadFromJsonAsync<IEnumerable<UsersClients>>();
                return View(users);
            }
            else
            {
                return View();
            }

        }
    }
}
