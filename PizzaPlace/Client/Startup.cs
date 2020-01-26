using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using PizzaPlace.Shared;
using PizzaPlace.Client.Services;

namespace PizzaPlace.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IMenuService, MenuService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddSingleton<State>();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
