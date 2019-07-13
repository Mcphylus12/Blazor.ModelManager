using Manager;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ModelManager.Components
{
    public static class ComponentsApplicationBuilderExtensions
    {
        public static void UseModelManagers(this IComponentsApplicationBuilder app, IModelManagerConfiguration configuration)
        {
            var serviceProvider = app.Services;

            IModelManagerRegister managerRegister = serviceProvider.GetService<IModelManagerRegister>();
            configuration.RegisterManagers(managerRegister);

            IModelStoreRegister storeRegister = serviceProvider.GetService<IModelStoreRegister>();
            configuration.RegisterStoreOverrides(storeRegister);
        }
    }
}
