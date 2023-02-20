
using DesignPattern;
using DesignPattern.Facade;
using DesignPattern.Factory;
using DesignPattern.Model;
using DesignPattern.Strategy;
var model = new NotificationModel();
model.Message = "oha neler";
model.MessageType = NotificationType.mail;
INotificationFacade notification = new NotificationFacade(new NotificationSender(new NotificationFactory()));

notification.send(model);
