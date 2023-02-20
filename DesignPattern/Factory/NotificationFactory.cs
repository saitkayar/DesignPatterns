using DesignPattern.ChainOfResponsibility;
using DesignPattern.Decarator;
using DesignPattern.Model;
using DesignPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory
{
    public class NotificationFactory : INotificationFactory
    {
        public IDictionary<NotificationType, INotification> CreateNotification()
        {
            return new Dictionary<NotificationType, INotification>() { 
            
            { NotificationType.mail,new NotificationChainDecorator( new MultipleDecarator( new MailNotification(),5),new SmsNotification())},
            { NotificationType.sms,new SmsNotification()},
            { NotificationType.push,new PushNotification()}};
        }
    }
}
