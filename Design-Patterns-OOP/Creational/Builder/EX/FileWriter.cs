using System;

namespace Design_Patterns_OOP.Creational.Builder.EX
{
    public class FileWriter
    {
        public string FileName { get; set; }

        public FileWriter(string fileName)
        {
            FileName = fileName;
        }

        public void write(string content)
        {
            Console.WriteLine("Write  " + content);
        }

        public void close()
        {
            Console.WriteLine("Close " + FileName);
        }
    }
}