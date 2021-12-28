using Design_Patterns_OOP.PayrollImp.Transactions.ChangeEmployee;
using Design_Patterns_OOP.PayrollImp.UnionMember;

namespace Design_Patterns_OOP.PayrollImp.Transactions.ChangeUnionMember
{
    public abstract class ChangeAffiliationTransaction : ChangeEmployeeTransaction
    {
        protected abstract Affiliation Affiliation { get; }
        protected abstract void RecordMembership(Employee e);

        public ChangeAffiliationTransaction(int empId) : base(empId) { }

        protected override void Change(Employee e)
        {
            RecordMembership(e);
            e.Affiliation = Affiliation;
        }
    }
}
