using System;
using ExtensionMethods;

namespace Design_Patterns_OOP.Facade
{
    public class NotificationServer
    {
        public string Connect(string ip) => $"connection {ip}";

        public string Authenticate(string appId, string key) => $"1232{appId}12 {key}312token";

        public void Send(string authToken, Message msg, string target)
        {
            // validate :_:
            if (authToken.IsNullOrWhiteSpace())
                return;


            Console.WriteLine($"Sending {msg.Content} to {target}");
        }

        public void Disconnect(string connection)
        {
            Console.WriteLine("Disconnect");
        }
    }
}

namespace ExtensionMethods
{
    public static class ExtensionsUtils
    {
        public static bool IsNullOrWhiteSpace(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }
    }
}