namespace Design_Patterns_OOP.Exercises.Strategy
{
    public class StDemo
    {
        public static void Show()
        {
            var chatClient = new ChatClient();
            chatClient.Send("Hello world", new AesEncryption());
        }
    }
}