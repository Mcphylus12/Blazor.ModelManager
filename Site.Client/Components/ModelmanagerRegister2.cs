using Manager;
using ModelManager.Managers;

namespace Site.Shared.Components
{
    public class ModelmanagerRegister2 : IModelManagerRegister
    {
        private ModelRequestManagerStore managerStore;

        public ModelmanagerRegister2(ModelRequestManagerStore managerStore)
        {
            this.managerStore = managerStore;
        }

        public void RegisterModelManager<TModel, TModelManager>()
            where TModelManager : ModelRequestManager
        {
            managerStore.RegisterModelManager<TModel, TModelManager>();
        }
    }
}
