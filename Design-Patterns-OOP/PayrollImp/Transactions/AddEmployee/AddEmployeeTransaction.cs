using Design_Patterns_OOP.PayrollImp.PaymentClassifications;
using Design_Patterns_OOP.PayrollImp.PaymentMethod;
using Design_Patterns_OOP.PayrollImp.PaymentSchedules;

namespace Design_Patterns_OOP.PayrollImp.Transactions.AddEmployee
{
    public abstract class AddEmployeeTransaction : Transaction
    {
        private readonly int empid;
        private readonly string name;
        private readonly string address;

        public AddEmployeeTransaction(int empid, string name, string address) : base(PayrollDatabase.instance)
        {
            this.empid = empid;
            this.name = name;
            this.address = address;
        }

        protected abstract PaymentClassification MakeClassification();
        protected abstract PaymentSchedule MakeSchedule();

        public override void Execute()
        {
            PaymentClassification pc = MakeClassification();
            PaymentSchedule ps = MakeSchedule();
            PaymentMethod.PaymentMethod pm = new HoldMethod();

            var e = new Employee(empid, name, address)
            {
                Classification = pc,
                Schedule = ps,
                Method = pm
            };

            database.AddEmployee(e);
        }
    }
}