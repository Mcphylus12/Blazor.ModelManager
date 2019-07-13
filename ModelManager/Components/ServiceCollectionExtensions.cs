using Manager;
using Microsoft.Extensions.DependencyInjection;

namespace ModelManager.Components
{
    public static class ServiceCollectionExtensions
    {
        public static void AddModelManagerServices(this IServiceCollection services, IModelManagerConfiguration configuration)
        {
            ModelRequestManagerStore managerStore = new ModelRequestManagerStore();
            services.AddSingleton(typeof(IModelRequestManagerStore), managerStore);

            ModelStoreCollection modelStore = new ModelStoreCollection();
            services.AddSingleton(typeof(IModelStoreCollection), modelStore);
            services.AddSingleton(typeof(IModelStoreRegister), modelStore);
            services.AddSingleton(typeof(IModelStorer), modelStore);

            services.AddSingleton(typeof(IModelProvider), typeof(ModelProvider));

            configuration.RegisterManagers(new ModelManagerRegisterer(managerStore, services));
            configuration.RegisterStoreOverrides(new ModelStoreRegisterer(modelStore, services));
        }
    }
}
