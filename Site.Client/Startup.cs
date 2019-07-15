using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using Site.Shared;

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
