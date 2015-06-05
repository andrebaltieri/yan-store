using System.Collections.Generic;
using YanStore.SharedKernel.Model;
using YanStore.SharedKernel.Model.Event;

namespace YanStore.CrossCutting.Events
{
    public class DomainNotificationHandle : IHandle<DomainNotification>
    {
        private List<DomainNotification> _notifications;

        public DomainNotificationHandle()
        {
            _notifications = new List<DomainNotification>();
        }

        public void Handle(DomainNotification args)
        {
            _notifications.Add(args);
        }

        public IEnumerable<DomainNotification> Notify()
        {
            return GetValue();
        }

        private List<DomainNotification> GetValue()
        {
            return _notifications;
        }

        public bool HasNotifications()
        {
            return GetValue().Count > 0;
        }
    }
}