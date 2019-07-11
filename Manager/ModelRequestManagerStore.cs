using System;
using System.Collections.Generic;

namespace Manager
{
    internal class ModelRequestManagerStore : IModelRequestManagerStore
    {
        private Dictionary<Type, IModelRequestManager> managers;

        public ModelRequestManagerStore()
        {
            managers = new Dictionary<Type, IModelRequestManager>();
        }

        public IModelRequestManager GetManager<T>()
        {
            return managers[typeof(T)];
        }

        public void RegisterModelManager<ModelType>(IModelRequestManager manager)
        {
            managers[typeof(ModelType)] = manager;
        }
    }
}