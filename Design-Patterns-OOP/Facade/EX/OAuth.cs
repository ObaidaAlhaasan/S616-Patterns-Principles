using System;

namespace Design_Patterns_OOP.Facade.EX
{
    public class OAuth
    {
        public String requestToken(String appKey, String appSecret)
        {
            Out.println("Get a request token");
            return "requestToken";
        }

        public String getAccessToken(String requestToken)
        {
            Out.println("Get an access token");
            return "accessToken";
        }
    }
}