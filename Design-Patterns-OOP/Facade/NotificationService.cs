using Design_Patterns_OOP.Mediator.EX;

namespace Design_Patterns_OOP.Facade
{
    public class NotificationService
    {
        public static void Send(string msg, string target)
        {
            var server = new NotificationServer();
            var connection = server.Connect("ip");
            var token = server.Authenticate("appId", "key");
            var message = new Message();
            message.SetContent(msg);
            server.Send(token, message, target);

            server.Disconnect(connection);
        }
    }
}