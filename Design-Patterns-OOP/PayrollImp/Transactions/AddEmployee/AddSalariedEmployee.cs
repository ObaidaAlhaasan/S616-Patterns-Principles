using Design_Patterns_OOP.PayrollImp.PaymentClassifications;
using Design_Patterns_OOP.PayrollImp.PaymentSchedules;

namespace Design_Patterns_OOP.PayrollImp.Transactions.AddEmployee
{
    public class AddSalariedEmployee : AddEmployeeTransaction
    {
        private readonly double salary;
        public AddSalariedEmployee(int id, string name, string address, double salary) : base(id, name, address)
        {
            this.salary = salary;
        }
        protected override PaymentClassification MakeClassification()
        {
            return new SalariedClassification(salary);
        }
        protected override PaymentSchedule MakeSchedule()
        {
            return new MonthlySchedule();
        }
    }
}
