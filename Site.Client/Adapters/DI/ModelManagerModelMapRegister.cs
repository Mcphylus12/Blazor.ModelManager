using System;
using Manager;

namespace Site.Client.Adapter.DI
{
    public class ModelManagerModelMapRegister : IModelManagerRegister
    {
        private ModelRequestManagerStore managerStore;

        public ModelManagerModelMapRegister(ModelRequestManagerStore managerStore)
        {
            this.managerStore = managerStore;
        }

        public void RegisterModelManager<TModel, TModelManager>()
            where TModelManager : ModelRequestManager
        {
            managerStore.RegisterModelManager<TModel, TModelManager>();
        }

        public void RegisterModelManager<TModel, TModelManager>(Func<TModelManager> factoryMethod) 
            where TModelManager : ModelRequestManager
        {
            RegisterModelManager<TModelManager, TModelManager>();
        }
    }
}
