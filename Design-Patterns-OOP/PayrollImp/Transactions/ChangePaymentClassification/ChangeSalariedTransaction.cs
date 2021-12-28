using Design_Patterns_OOP.PayrollImp.PaymentClassifications;
using Design_Patterns_OOP.PayrollImp.PaymentSchedules;

namespace Design_Patterns_OOP.PayrollImp.Transactions.ChangePaymentClassification
{
    public class ChangeSalariedTransaction : ChangeClassificationTransaction
    {
        private readonly double salary;
        public ChangeSalariedTransaction(int empId, double salary) : base(empId)
        {
            this.salary = salary;
        }
        protected override PaymentClassification Classification
        {
            get { return new SalariedClassification(salary); }
        }
        protected override PaymentSchedule Schedule
        {
            get { return new MonthlySchedule(); }
        }
    }
}
