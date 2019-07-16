using Manager;
using Microsoft.Extensions.DependencyInjection;

namespace Site.Client.Adapter.DI
{
    public class ModelStoreTypeRegister : IModelStoreRegister
    {
        private IServiceCollection services;

        public ModelStoreTypeRegister(IServiceCollection services)
        {
            this.services = services;
        }

        public void RegisterStoreOverride<TModel>(IModelStore store)
        {
            
        }
    }
}

