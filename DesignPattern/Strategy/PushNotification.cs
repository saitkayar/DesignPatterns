using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    public class PushNotification : INotification
    {
        public bool Send(NotificationModel notification)
        {
            Console.WriteLine($"Push:{notification.Message}");

            return true;
        }
    }
}
