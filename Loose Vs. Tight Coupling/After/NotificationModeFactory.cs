namespace Loose_Vs._Tight_Coupling.After
{
    public class NotificationModeFactory
    {
        public static INotificationMode Create(NotificationMode mode)
        {
            switch(mode)
            {
                case NotificationMode.EMAIL:
                    return new EmailService();
                case NotificationMode.SMS:
                    return new SmsService();
                case NotificationMode.WEIRD:
                    return new WeirdService();
                default:
                    return new EmailService();

            }
        }
    }
}
