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
            services.AddModelManagerServices(new ModelManagerConfiguration());
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    }
}
