using Manager;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ModelManager
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(typeof(IModelRequestManagerStore), typeof(ModelRequestManagerStore));
            services.AddSingleton(typeof(IModelProvider), typeof(ModelProvider));
        }

        public void Configure(IComponentsApplicationBuilder app)
        {
            app.AddComponent<App>("app");

            var managers = app.Services.GetService<IModelRequestManagerStore>();
        }
    }
}
