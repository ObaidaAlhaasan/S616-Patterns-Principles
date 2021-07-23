using System;
using System.Collections.Generic;

namespace Design_Patterns_OOP.Facade.EX
{
    public class TwitterClient
    {
        public List<Tweet> getRecentTweets(String accessToken)
        {
            System.Out.println("Getting recent tweets");

            return new ArrayList<Tweet>();
        }

        public void Tweet(string msg, string accessToken)
        {
            Console.WriteLine($"Sending {msg}");
        }
    }
}