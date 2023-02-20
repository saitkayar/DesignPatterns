﻿using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory
{
    public interface INotificationFactory
    {
        IDictionary<NotificationType , INotification> CreateNotification();
    }
}
