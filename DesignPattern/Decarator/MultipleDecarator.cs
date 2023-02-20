using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decarator
{
    public class MultipleDecarator : INotification
    {
        private readonly INotification decarator;
        public int time { get; set; }

        public MultipleDecarator(INotification decarator, int time)
        {
            this.decarator = decarator;
            this.time = time;
        }

        public bool Send(NotificationModel notification)
        {
            for (var i = 0; i < time; i++)
            {
            return  decarator.Send(notification);
            }
            return true;
        }
    }
}
