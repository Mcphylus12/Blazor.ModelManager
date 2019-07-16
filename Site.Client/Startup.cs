using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using Site.Client.Adapter.Blazor;
using Site.Client.Adapter.DI;

namespace Site.Client
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddModelManagerServices(new ModelManagerCofiguration());
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
            app.AddModelManagers(new ModelManagerCofiguration());
        }
    }
}
