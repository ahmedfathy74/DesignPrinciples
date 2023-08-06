namespace Loose_Vs._Tight_Coupling.After
{
    public class WeirdService : INotificationMode
    {
        public void Send()
        {
            Console.WriteLine("blabla  sent");
        }
    }
}
