using System.Collections.Generic;

namespace DependencyInversion.After
{
    public class NotificationService
    {
        private readonly List<IMessageService> _services;

        // Constructor Injection
        public NotificationService(List<IMessageService> services)
        {
            _services = services;
        }
        public void Notify()
        {
           foreach(var service in _services)
            {
                service.Send();
            }
        }
    }
    public class NotificationService1
    {
        // Property Injection
        public List<IMessageService> Services { get; private set; } = new();

        public void Notify()
        {
            foreach (var service in Services)
            {
                service.Send();
            }
        }
        public void SetServices(List<IMessageService> services)
        {
            this.Services = services;
        }
    }
    public class NotificationService2
    {
        // Method Injection

        public void Notify(List<IMessageService> services)
        {
            foreach (var service in services)
            {
                service.Send();
            }
        }  
    }
}
