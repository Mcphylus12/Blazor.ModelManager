using System;

namespace Manager
{
    public class ModelProvider : IModelProvider
    {
        private readonly IModelRequestManagerStore _modelRequestManagerStore;
        private readonly IModelStoreCollection _modelStoreCollection;

        public ModelProvider(IModelRequestManagerStore managerStore)
        {
            this._modelRequestManagerStore = managerStore;
            this._modelStoreCollection = new ModelStoreCollection();
        }

        public IModelHandle<T> RequestHandle<T>()
            where T : class
        {
            IModelRequestManager manager = _modelRequestManagerStore.GetManager<T>();
            IModelStore modelStore = _modelStoreCollection.GetStore<T>();
            ModelHandle<T> handle = new ModelHandle<T>(manager, modelStore);

            return handle;
        }
    }
}
