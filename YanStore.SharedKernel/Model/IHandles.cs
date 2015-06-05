using System.Collections.Generic;

namespace YanStore.SharedKernel.Model
{
    public interface IHandle<T> where T : IDomainEvent
    {
        void Handle(T args);
        IEnumerable<T> Notify();
        bool HasNotifications();
    }
}
