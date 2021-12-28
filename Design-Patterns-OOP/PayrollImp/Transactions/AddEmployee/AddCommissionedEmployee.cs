using Design_Patterns_OOP.PayrollImp.PaymentClassifications;
using Design_Patterns_OOP.PayrollImp.PaymentSchedules;

namespace Design_Patterns_OOP.PayrollImp.Transactions.AddEmployee
{
    public class AddCommissionedEmployee : AddEmployeeTransaction
    {
        private readonly int empid;
        private readonly double salary;
        private readonly double comissionRate;
        public AddCommissionedEmployee(int empid, string name, string address, double salary, double comissionRate) : base(empid, name, address)
        {
            this.empid = empid;
            this.salary = salary;
            this.comissionRate = comissionRate;
        }
        protected override PaymentClassification MakeClassification()
        {
            return new ComissinedClassification(empid, salary, comissionRate);
        }
        protected override PaymentSchedule MakeSchedule()
        {
            return new BiweeklySchedule();
        }
    }
}
