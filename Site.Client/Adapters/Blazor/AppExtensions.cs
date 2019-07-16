using Manager;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using Site.Client.Adapter.DI;

namespace Site.Client.Adapter.Blazor
{
    public static class AppExtensions
    {
        public static void AddModelManagers(this IComponentsApplicationBuilder app, IModelManagerConfiguration configuration)
        {
            var serviceProvider = app.Services;

            ModelRequestManagerStore manager = serviceProvider.GetService<ModelRequestManagerStore>();
            ModelStoreCollection store = serviceProvider.GetService<ModelStoreCollection>();

            configuration.RegisterManagers(new ModelManagerModelMapRegister(manager));
            configuration.RegisterStoreOverrides(new ModelStoreModelMapRegister(store));
        }
    }
}
