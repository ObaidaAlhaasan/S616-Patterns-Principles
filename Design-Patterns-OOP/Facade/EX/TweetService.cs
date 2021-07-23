using System.Collections.Generic;

namespace Design_Patterns_OOP.Facade.EX
{
    public class TweetService
    {
        private readonly TwitterClient twitterClient;
        private readonly string accessToken;

        public TweetService()
        {
            var oauth = new OAuth();
            var requestToken = oauth.requestToken("appKey", "secret");
            accessToken = oauth.getAccessToken(requestToken);
            twitterClient = new TwitterClient();
        }

        public void Tweet(string msg)
        {
            twitterClient.Tweet(msg, accessToken);
        }

        public IEnumerable<Tweet> GetRecentTweets()
        {
            return twitterClient.getRecentTweets(accessToken);
        }
    }
}