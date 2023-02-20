using DesignPattern.Model;

namespace DesignPattern.Strategy
{
    public class MailNotification : INotification
    {
        public bool Send(NotificationModel notification)
        {
            Console.WriteLine($"Mail:{notification.Message}");

            return false;
        }
    }
}
