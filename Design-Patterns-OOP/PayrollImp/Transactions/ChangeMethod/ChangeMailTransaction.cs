using Design_Patterns_OOP.PayrollImp.PaymentMethod;

namespace Design_Patterns_OOP.PayrollImp.Transactions.ChangeMethod
{
    public class ChangeMailTransaction : ChangeMethodTransaction
    {
        private readonly string address;
        public ChangeMailTransaction(int empId, string address) : base(empId)
        {
            this.address = address;
        }
        protected override PaymentMethod.PaymentMethod Method
        {
            get { return new MailMethod(address); }
        }
    }
}
