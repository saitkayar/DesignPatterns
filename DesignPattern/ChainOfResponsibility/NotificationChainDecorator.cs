using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ChainOfResponsibility
{
    public class NotificationChainDecorator : INotification
    {
        private readonly INotification notif;
        private readonly INotification change;

        public NotificationChainDecorator(INotification notif, INotification change)
        {
            this.notif = notif;
            this.change = change;
        }

        public bool Send(NotificationModel notification)
        {
            if (notif.Send(notification))
            {
                return true;
            }
            return change.Send(notification);
        }
    }
}
