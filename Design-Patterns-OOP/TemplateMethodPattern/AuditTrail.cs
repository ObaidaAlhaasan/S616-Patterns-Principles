using System;

namespace Design_Patterns_OOP.TemplateMethodPattern
{
    public class AuditTrail
    {
        public void Record()
        {
            Console.WriteLine("Recording User Changes....");
        }
    }
}