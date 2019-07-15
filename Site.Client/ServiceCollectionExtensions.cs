using Manager;
using Microsoft.Extensions.DependencyInjection;
using ModelManager.Components;
using System;

namespace Site.Client
{
    public static class ServiceCollectionExtensions
    {
        public static void AddModelManagerServices(this IServiceCollection services, IModelManagerConfiguration configuration)
        {
            services.AddSingleton<ModelRequestManagerStore>();
            services.AddSingleton<IModelRequestManagerStore>(provider => provider.GetService<ModelRequestManagerStore>());

            ModelStoreCollection modelStore = new ModelStoreCollection();
            services.AddSingleton<IModelStoreCollection>(modelStore);
            services.AddSingleton<IModelStoreRegister>(modelStore);
            services.AddSingleton<IModelStorer>(modelStore);

            services.AddSingleton(typeof(IModelProvider), typeof(ModelProvider));
            services.AddSingleton<IModelManagerResolver, ServiceProviderAdapter>();

            configuration.RegisterManagers(new ModelManagerRegisterer(services));
            configuration.RegisterStoreOverrides(new ModelStoreRegisterer(modelStore, services));
        }
    }
}
