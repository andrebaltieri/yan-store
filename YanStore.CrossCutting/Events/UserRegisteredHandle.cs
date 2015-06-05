using System.Collections.Generic;
using YanStore.Domain.Model.Event;
using YanStore.SharedKernel.Model;

namespace YanStore.CrossCutting.Events
{
    public class UserRegisteredHandle : IHandle<UserRegistered>
    {
        private List<UserRegistered> _notifications;

        public void Handle(UserRegistered args)
        {
            // Enviar Email   
            string emailForBreakPoint = "";         
        }

        public bool HasNotifications()
        {
            return GetValue().Count > 0;
        }

        public IEnumerable<UserRegistered> Notify()
        {
            return GetValue();
        }

        private List<UserRegistered> GetValue()
        {
            return _notifications;
        }
    }
}