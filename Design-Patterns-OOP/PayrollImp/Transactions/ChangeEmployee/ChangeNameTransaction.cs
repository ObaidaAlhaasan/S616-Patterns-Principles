namespace Design_Patterns_OOP.PayrollImp.Transactions.ChangeEmployee
{
    public class ChangeNameTransaction : ChangeEmployeeTransaction
    {
        private readonly string newName;
        public ChangeNameTransaction(int empId, string newName) : base(empId)
        {
            this.newName = newName;
        }
        protected override void Change(Employee e)
        {
            e.Name = newName;
        }
    }
}
