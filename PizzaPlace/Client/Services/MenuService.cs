using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using PizzaPlace.Shared;
using Microsoft.AspNetCore.Components;

namespace PizzaPlace.Client.Services
{
    public class MenuService : IMenuService
    {
        private HttpClient http;

        public MenuService(HttpClient http)
        {
            this.http = http;
        }
        public async Task<Menu> GetMenu()
        {
            var pizzas = await http.GetJsonAsync<Pizza[]>("/pizzas");
            return new Menu { Pizzas = pizzas.ToList() };
        }
    }
}
