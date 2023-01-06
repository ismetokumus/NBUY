﻿using GetCountriesFromApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GetCountriesFromApi.Controllers
{
    public class HomeController : Controller
    {
        

        public async Task<IActionResult> Index()
        {
            List<CountryViewModel> countryList = new List<CountryViewModel>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://restcountries.com/v3.1/all"))
                {
                    var stringResponse = await response.Content.ReadAsStringAsync();
                    countryList = JsonSerializer.Deserialize<List<CountryViewModel>>(stringResponse);
                } 
            }
            return View(countryList);
        }

        
    }
}