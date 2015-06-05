using Microsoft.Practices.Unity;
using YanStore.CrossCutting.Events;
using YanStore.Domain.Application;
using YanStore.Domain.Model.Event;
using YanStore.Domain.Model.Repository;
using YanStore.Infra.Context;
using YanStore.Infra.Repositories;
using YanStore.SharedKernel.Model;
using YanStore.SharedKernel.Model.Event;

namespace YanStore.CrossCutting
{
    public class DependencyResolver
    {
        public void Resolve(UnityContainer container)
        {
            container.RegisterType<StoreDataContext, StoreDataContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserRepository, UserRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserApplicationService, UserApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<IHandle<DomainNotification>, DomainNotificationHandle>(new HierarchicalLifetimeManager());
            container.RegisterType<IHandle<UserRegistered>, UserRegisteredHandle>(new HierarchicalLifetimeManager());
        }
    }
}
