using System;
using Design_Patterns_OOP.Facade.EX;

namespace Design_Patterns_OOP.Facade
{
    public class FaDemo
    {
        public static void Show()
        {
            NotificationService.Send("hello world!", "target");
        }

        public static void ExShow()
        {
            TweetService service = new TweetService();

            service.Tweet("Hello world!");
            var tweets = service.GetRecentTweets();
        }
    }
}