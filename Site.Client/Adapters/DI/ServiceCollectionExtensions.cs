using Manager;
using Microsoft.Extensions.DependencyInjection;

namespace Site.Client.Adapter.DI
{
    public static class ServiceCollectionExtensions
    {
        public static void AddModelManagerServices(this IServiceCollection services, IModelManagerConfiguration configuration)
        {
            services.AddSingleton<ModelRequestManagerStore>();
            services.AddSingleton<IModelRequestManagerStore>(provider => provider.GetService<ModelRequestManagerStore>());

            ModelStoreCollection modelStore = new ModelStoreCollection();
            services.AddSingleton(modelStore);
            services.AddSingleton<IModelStoreCollection>(modelStore);
            services.AddSingleton<IModelStorer>(modelStore);

            services.AddSingleton(typeof(IModelProvider), typeof(ModelProvider));
            services.AddSingleton<IModelManagerResolver, ServiceProviderAdapter>();

            configuration.RegisterManagers(new ModelManagerTypeRegister(services));
            configuration.RegisterStoreOverrides(new ModelStoreTypeRegister(services));
        }
    }
}
