using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Facade
{
    public interface INotificationFacade
    {
        void send(NotificationModel notification);
    }
    public class NotificationFacade : INotificationFacade
    {
        private readonly INotificationSender sender;

        public NotificationFacade(INotificationSender sender)
        {
            this.sender = sender;
        }

        public void send(NotificationModel notification)
        {
            sender.Send(notification);
        }
    }
}
