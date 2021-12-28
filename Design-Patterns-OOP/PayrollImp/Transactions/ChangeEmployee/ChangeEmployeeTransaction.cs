using System;

namespace Design_Patterns_OOP.PayrollImp.Transactions.ChangeEmployee
{
    public abstract class ChangeEmployeeTransaction : ITransaction
    {
        private readonly int empId;
        public ChangeEmployeeTransaction(int empId)
        {
            this.empId = empId;
        }
        public void Execute()
        {
            Employee e = PayrollDatabase.GetEmployee(empId);
            if (e != null)
                Change(e);
            else
                throw new InvalidOperationException("No such employee.");
        }
        protected abstract void Change(Employee e);
    }
}
