using Manager;
using Microsoft.Extensions.DependencyInjection;

namespace ModelManager.Components
{
    public class ModelStoreRegisterer : IModelStoreRegister
    {
        private ModelStoreCollection modelStore;
        private IServiceCollection services;

        public ModelStoreRegisterer(ModelStoreCollection modelStore, IServiceCollection services)
        {
            this.modelStore = modelStore;
            this.services = services;
        }

        public void RegisterStoreOverride<TModel, TModelStore>() 
            where TModelStore : class, IModelStore 
        {
            services.AddSingleton<TModelStore>();
            modelStore.RegisterStoreOverride<TModel, TModelStore>();
        }
    }
}
