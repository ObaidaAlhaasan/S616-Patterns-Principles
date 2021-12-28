using Design_Patterns_OOP.PayrollImp.PaymentClassifications;
using Design_Patterns_OOP.PayrollImp.PaymentSchedules;

namespace Design_Patterns_OOP.PayrollImp.Transactions.AddEmployee
{
    public class AddHourlyEmployee : AddEmployeeTransaction
    {
        private readonly int empid;
        private readonly double hourRate;
        public AddHourlyEmployee(int empid, string name, string address, double hourRate) : base(empid, name, address)
        {
            this.empid = empid;
            this.hourRate = hourRate;
        }
        protected override PaymentClassification MakeClassification()
        {
            return new HourlyClassification(empid, hourRate);
        }
        protected override PaymentSchedule MakeSchedule()
        {
            return new WeeklySchedule();
        }
    }
}
