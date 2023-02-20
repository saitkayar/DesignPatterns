using DesignPattern.Factory;
using DesignPattern.Model;

namespace DesignPattern
{
    public class NotificationSender : INotificationSender
    {
        private readonly INotificationFactory factory;

        public NotificationSender(INotificationFactory factory)
        {
            this.factory = factory;
        }

        public void Send(NotificationModel message)
        {
            factory.CreateNotification()[message.MessageType].Send(message);
        }
    }
}
