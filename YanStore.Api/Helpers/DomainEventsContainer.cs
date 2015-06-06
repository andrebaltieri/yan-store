using System;
using System.Collections.Generic;
using YanStore.SharedKernel.Model;

namespace YanStore.Api.Helpers
{
    public class DomainEventsContainer : IContainer
    {
        private UnityResolverHelper _resolver;

        public DomainEventsContainer(UnityResolverHelper resolver)
        {
            _resolver = resolver;
        }

        public object GetService(Type serviceType)
        {
            return _resolver.GetService(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _resolver.GetServices(serviceType);
        }
    }
}