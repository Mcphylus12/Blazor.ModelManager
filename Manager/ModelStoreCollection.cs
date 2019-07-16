using System;
using System.Collections.Generic;

namespace Manager
{
    public class ModelStoreCollection : IModelStoreCollection, IModelStorer
    {
        private Dictionary<Type, IModelStore> modelStore;

        public ModelStoreCollection()
        {
            modelStore = new Dictionary<Type, IModelStore>();
        }

        public IModelStore GetStore<T>()
        {
            if (!modelStore.ContainsKey(typeof(T)))
            {
                modelStore.Add(typeof(T), new ModelStore());
            }

            return modelStore[typeof(T)];
        }

        public void RegisterStoreOverride<TModel>(IModelStore store)
        {
            modelStore.Add(typeof(TModel), store);
        }

        public void StoreModel<T>(string key, T model)
        {
            var store = GetStore<T>();

            store.UpdateModel(key, model);
        }
    }
}