using Manager;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using Site.Shared.Components;

namespace Site.Client
{
    public static class AppExtensions
    {
        public static void AddModelManagers(this IComponentsApplicationBuilder app, IModelManagerConfiguration configuration)
        {
            var serviceProvider = app.Services;

            ModelRequestManagerStore thing = serviceProvider.GetService<ModelRequestManagerStore>();

            configuration.RegisterManagers(new ModelmanagerRegister2(thing));
        }
    }
}
