using System;
using System.Collections.Generic;

namespace Design_Patterns_OOP.Creational.Singleton
{
    public class Logger
    {
        private static Dictionary<string, Logger> instances = new();

        private string fileName;

        private Logger(string fileName)
        {
            this.fileName = fileName;
        }


        public static Logger GetInstance(string fileName)
        {
            if (instances.TryGetValue(fileName, out var logger))
                return logger;

            instances.TryAdd(fileName, new Logger(fileName));

            return instances.GetValueOrDefault(fileName);
        }

        public void Write(string message)
        {
            System.Out.println("Writing a message to the log.");
        }
    }
}