using System;
using System.Collections.Generic;

namespace YanStore.SharedKernel.Model
{
    public interface IContainer
    {
        object GetService(Type serviceType);
        IEnumerable<object> GetServices(Type serviceType);
    }
}
