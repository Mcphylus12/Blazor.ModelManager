using Manager;
using Microsoft.Extensions.DependencyInjection;
using ModelManager.Managers;

namespace ModelManager.Components
{
    public class ModelManagerRegisterer : IModelManagerRegister
    {
        private IServiceCollection services;

        public ModelManagerRegisterer(IServiceCollection services)
        {
            this.services = services;
        }

        public void RegisterModelManager<TModel, TModelManager>() 
            where TModelManager : ModelRequestManager
        {
            services.AddSingleton<TModelManager>();
        }
    }
}