namespace Loose_Vs._Tight_Coupling.After
{
    public class EmailService : INotificationMode
    {
        public void Send()
        {
            Console.WriteLine("email sent");
        }
    }
}
