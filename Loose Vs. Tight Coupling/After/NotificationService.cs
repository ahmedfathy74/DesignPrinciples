using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Vs._Tight_Coupling.After
{
    public class NotificationService
    {
        private readonly INotificationMode _notificationMode;
        public NotificationService(INotificationMode notificationMode)
        {
            _notificationMode = notificationMode;
        }
        public void Notify()
        {
            _notificationMode.Send();
        }
    }
}
