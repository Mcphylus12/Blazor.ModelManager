using System;
using System.Collections.Generic;

namespace Manager
{
    public class ModelRequestManagerStore : IModelRequestManagerStore, IModelManagerRegister
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
            managers.Add(typeof(ModelType), manager);
        }

        public void RegisterModelManager<TModel, TModelManager>()
            where TModelManager : IModelRequestManager
        {

        }
    }
}