using Design_Patterns_OOP.PayrollImp.Transactions.ChangeEmployee;

namespace Design_Patterns_OOP.PayrollImp.Transactions.ChangeMethod
{
    public abstract class ChangeMethodTransaction : ChangeEmployeeTransaction
    {
        protected abstract PaymentMethod.PaymentMethod Method { get; }

        public ChangeMethodTransaction(int empId) : base(empId) { }

        protected override void Change(Employee e)
        {
            e.Method = Method;
        }
    }
}
