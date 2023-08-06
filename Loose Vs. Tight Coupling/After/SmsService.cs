namespace Loose_Vs._Tight_Coupling.After
{
    public class SmsService : INotificationMode
    {
        public void Send()
        {
            Console.WriteLine("sms sent");
        }
    }
}
