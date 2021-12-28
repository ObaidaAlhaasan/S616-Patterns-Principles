using Design_Patterns_OOP.PayrollImp.PaymentMethod;

namespace Design_Patterns_OOP.PayrollImp.Transactions.ChangeMethod
{
    public class ChangeHoldTransaction : ChangeMethodTransaction
    {
        public ChangeHoldTransaction(int empId) : base(empId) { }
        protected override PaymentMethod.PaymentMethod Method
        {
            get { return new HoldMethod(); }
        }
    }
}
