using Manager;
using Microsoft.Extensions.DependencyInjection;

namespace ModelManager.Components
{
    public static class ServiceCollectionExtensions
    {
        public static void AddModelManagerService(this IServiceCollection services)
        {
            ModelRequestManagerStore managerStore = new ModelRequestManagerStore();
            services.AddSingleton(typeof(IModelRequestManagerStore), managerStore);
            services.AddSingleton(typeof(IModelManagerRegister), managerStore);

            ModelStoreCollection storeCollection = new ModelStoreCollection();
            services.AddSingleton(typeof(IModelStorer), storeCollection);
            services.AddSingleton(typeof(IModelStoreRegister), storeCollection);
            services.AddSingleton(typeof(IModelStoreCollection), storeCollection);

            services.AddSingleton(typeof(IModelProvider), typeof(ModelProvider));
        }
    }
}
