using Design_Patterns_OOP.PayrollImp.PaymentMethod;

namespace Design_Patterns_OOP.PayrollImp.Transactions.ChangeMethod
{
    public class ChangeDirectTransaction : ChangeMethodTransaction
    {
        private readonly string bank;
        private readonly string account;
        public ChangeDirectTransaction(int empId, string bank, string account) : base(empId)
        {
            this.bank = bank;
            this.account = account;
        }
        protected override PaymentMethod.PaymentMethod Method
        {
            get { return new DirectMethod(bank, account); }
        }
    }
}
