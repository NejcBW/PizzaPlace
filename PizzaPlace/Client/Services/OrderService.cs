using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Linq;
using System.Threading.Tasks;
using PizzaPlace.Shared;
using Microsoft.AspNetCore.Components;

namespace PizzaPlace.Client.Services
{
    public class OrderService : IOrderService
    {
        private HttpClient http;

        public OrderService(HttpClient http)
        {
            this.http = http;
        }

        public async Task PlaceOrder(Basket basket)
        {
            await http.PostJsonAsync("/orders", basket);
        }

    }
}
