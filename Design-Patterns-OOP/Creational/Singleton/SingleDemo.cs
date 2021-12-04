using System;

namespace Design_Patterns_OOP.Creational.Singleton
{
    public class SingleDemo
    {
        public static void Show()
        {
            ConfigManager manager = ConfigManager.GetInstance();
            manager.AddSetting("name", "hello");
            manager.AddSetting("password", "234");

            Console.WriteLine(manager.GetSetting("password"));
        }

        public static void EXShow()
        {
            var logger1 = Logger.GetInstance("file1");
            var logger2 = Logger.GetInstance("file1");
            Out.println(logger1 == logger2);

            var logger3 = Logger.GetInstance("file2");
            Out.println(logger1 == logger3);
        }
    }
}