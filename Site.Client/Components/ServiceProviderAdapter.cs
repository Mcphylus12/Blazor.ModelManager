using System;
using Manager;

namespace ModelManager.Components
{
    public class ServiceProviderAdapter : IModelManagerResolver
    {
        private readonly IServiceProvider serviceProvider;

        public ServiceProviderAdapter(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public IModelRequestManager GetManager(Type managerType)
        {
            return (IModelRequestManager)serviceProvider.GetService(managerType);
        }
    }
}
