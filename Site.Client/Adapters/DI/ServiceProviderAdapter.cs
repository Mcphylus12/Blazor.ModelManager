using Manager;
using System;

namespace Site.Client.Adapter.DI
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
