using Design_Patterns_OOP.Decorator.EX;

namespace Design_Patterns_OOP.Decorator
{
    public class DecDemo
    {
        public static void Show()
        {
            var clStream = new EncryptedCloudStream(new CompressedCloudStream(new CloudStream()));
            clStream.write("Some Data to write");
        }


        public static void EXShow()
        {
            var editor = new Editor();
            editor.openProject("...");
        }
    }
}