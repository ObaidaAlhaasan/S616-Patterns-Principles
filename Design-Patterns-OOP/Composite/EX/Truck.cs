using System;

namespace Design_Patterns_OOP.Composite.EX
{
    public class Truck : Resource
    {
        public override void Deploy()
        {
            Out.Println("Deploying a truck");
        }
    }
}
