using System;
using System.Collections.Generic;

namespace Manager
{
    public class ModelRequestManagerStore : IModelRequestManagerStore
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

        public void RegisterModelManager<TModel, TModelManager>()
            where TModelManager : IModelRequestManager
        {
            //Write DI adapter for resolving modedl manager
        }
    }
}