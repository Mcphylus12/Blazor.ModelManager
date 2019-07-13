using Manager;
using Microsoft.Extensions.DependencyInjection;
using ModelManager.Managers;

namespace ModelManager.Components
{
    internal class ModelManagerRegisterer : IModelManagerRegister
    {
        private ModelRequestManagerStore managerStore;
        private IServiceCollection services;

        public ModelManagerRegisterer(ModelRequestManagerStore managerStore, IServiceCollection services)
        {
            this.managerStore = managerStore;
            this.services = services;
        }

        public void RegisterModelManager<TModel, TModelManager>() 
            where TModelManager : ModelRequestManager
        {
            services.AddSingleton<TModelManager>();
            managerStore.RegisterModelManager<TModel, TModelManager>();
        }
    }
}