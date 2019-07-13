using System;
using System.Collections.Generic;

namespace Manager
{
    public class ModelStoreCollection : IModelStoreCollection, IModelStorer, IModelStoreRegister
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

        public void RegisterStoreOverride<TModel, TStore>() 
            where TStore : IModelStore
        {
            throw new NotImplementedException();
        }

        public void StoreModel<T>(string key, T model)
        {
            var store = GetStore<T>();

            store.UpdateModel(key, model);
        }
    }
}