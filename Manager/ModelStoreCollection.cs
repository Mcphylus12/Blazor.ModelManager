using System;
using System.Collections.Generic;

namespace Manager
{
    internal class ModelStoreCollection : IModelStoreCollection, IModelStorer
    {
        private Dictionary<Type, IModelStore> modelStore;

        public ModelStoreCollection()
        {
            modelStore = new Dictionary<Type, IModelStore>();
        }

        public IModelStore GetStore<T>()
        {
            return modelStore[typeof(T)];
        }

        public void StoreModel<T>(string key, T model)
        {
            var store = GetStore<T>();

            store.UpdateModel(key, model);
        }
    }
}