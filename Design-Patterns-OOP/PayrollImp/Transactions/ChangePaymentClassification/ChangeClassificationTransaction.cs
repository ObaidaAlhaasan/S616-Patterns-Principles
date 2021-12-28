using Design_Patterns_OOP.PayrollImp.PaymentClassifications;
using Design_Patterns_OOP.PayrollImp.PaymentSchedules;
using Design_Patterns_OOP.PayrollImp.Transactions.ChangeEmployee;

namespace Design_Patterns_OOP.PayrollImp.Transactions.ChangePaymentClassification
{
    public abstract class ChangeClassificationTransaction : ChangeEmployeeTransaction
    {
        protected abstract PaymentClassification Classification { get; }
        protected abstract PaymentSchedule Schedule { get; }

        public ChangeClassificationTransaction(int empId) : base(empId) { }

        protected override void Change(Employee e)
        {
            e.Classification = Classification;
            e.Schedule = Schedule;
        }
    }
}
