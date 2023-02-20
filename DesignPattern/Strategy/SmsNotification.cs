using DesignPattern.Model;

namespace DesignPattern.Strategy
{
    public class SmsNotification : INotification
    {
        public bool Send(NotificationModel notification)
        {
            Console.WriteLine($"Sms:{notification.Message}");
            return true;
        }
    }
}
