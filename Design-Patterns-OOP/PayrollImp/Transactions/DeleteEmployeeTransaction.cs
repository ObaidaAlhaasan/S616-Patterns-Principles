namespace Design_Patterns_OOP.PayrollImp.Transactions
{
    public class DeleteEmployeeTransaction : ITransaction
    {
        private readonly int id;
        public DeleteEmployeeTransaction(int id)
        {
            this.id = id;
        }
        public void Execute()
        {
            PayrollDatabase.DeleteEmployee(id);
        }
    }
}
