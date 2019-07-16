using System;
using Manager;
using Microsoft.Extensions.DependencyInjection;

namespace Site.Client.Adapter.DI
{
    public class ModelManagerTypeRegister : IModelManagerRegister
    {
        private IServiceCollection services;

        public ModelManagerTypeRegister(IServiceCollection services)
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