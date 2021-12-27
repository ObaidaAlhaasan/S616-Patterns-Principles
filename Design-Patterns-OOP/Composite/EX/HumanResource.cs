namespace Design_Patterns_OOP.Composite.EX
{
    public class HumanResource : Resource
    {
        public override void Deploy()
        {
            Out.Println("Deploying a human resource");
        }
    }
}