using GetCountriesFromApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;

namespace GetCountriesFromApi.Controllers
{
    public class HomeController : Controller
    {
        

        public async Task<IActionResult> Index()
        {
            List<CountryViewModel> countryList = new List<CountryViewModel>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://restcountries.com/v2/all"))
                {
                    var stringResponse = await response.Content.ReadAsStringAsync();
                    countryList = JsonSerializer.Deserialize<List<CountryViewModel>>(stringResponse);
                }
            }
            return View(countryList);
        }

        public async Task<IActionResult> User()
        {
            List<UserViewModel> userList = new List<UserViewModel>();
            using (var httpClient = new HttpClient())
            {
                using (var responsee = await httpClient.GetAsync("https://reqres.in/api/users?page=2"))
                {
                    
                    var stringgResponse = await responsee.Content.ReadAsStringAsync();
                    stringgResponse = stringgResponse.Replace[];
                    userList = JsonSerializer.Deserialize<List<UserViewModel>>(stringgResponse);
                }
            }
            return View(userList);
        }
    }
}