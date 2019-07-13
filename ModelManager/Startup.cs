using Manager;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using ModelManager.Components;
using Models;

namespace ModelManager
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddModelManagerService();
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");

            app.UseModelManagers(new ModelManagerConfiguration());
        }
    }
}
