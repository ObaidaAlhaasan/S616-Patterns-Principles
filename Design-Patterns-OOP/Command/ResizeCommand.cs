using System;
using Design_Patterns_OOP.Command.Framework;

namespace Design_Patterns_OOP.Command
{
    public class ResizeCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Resize");
        }
    }


    public class BlackAndWhiteCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("BlackAndWhite");
        }
    }
}