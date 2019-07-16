using Manager;

namespace Site.Client.Adapter.DI
{
    public class ModelStoreModelMapRegister : IModelStoreRegister
    {
        private ModelStoreCollection modelStore;

        public ModelStoreModelMapRegister(ModelStoreCollection modelStore)
        {
            this.modelStore = modelStore;
        }

        public void RegisterStoreOverride<TModel>(IModelStore store)
        {
            modelStore.RegisterStoreOverride<TModel>(store);
        }
    }
}

