using System;
using System.Collections.Generic;

namespace Manager
{
    public class ModelRequestManagerStore : IModelRequestManagerStore
    {
        private readonly IModelManagerResolver typeResolver;
        private Dictionary<Type, Type> managers;

        public ModelRequestManagerStore(IModelManagerResolver typeResolver)
        {
            managers = new Dictionary<Type, Type>();
            this.typeResolver = typeResolver;
        }

        public IModelRequestManager GetManager<T>()
        {
            Type managerType = managers[typeof(T)];

            return typeResolver.GetManager(managerType);
        }

        public void RegisterModelManager<TModel, TModelManager>()
            where TModelManager : IModelRequestManager
        {
            managers.Add(typeof(TModel), typeof(TModelManager));
        }
    }
}