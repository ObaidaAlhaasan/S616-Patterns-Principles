using Design_Patterns_OOP.PayrollImp.UnionMember;

namespace Design_Patterns_OOP.PayrollImp.Transactions.ChangeUnionMember
{
    public class ChangeUnaffiliatedTransaction : ChangeAffiliationTransaction
    {
        private readonly int memberId;
        private double dues;
        public ChangeUnaffiliatedTransaction(int empId) : base(empId) {}
        protected override Affiliation Affiliation
        {
            get { return new NoAffiliation(); }
        }

        protected override void RecordMembership(Employee e) {
            Affiliation affiliation = e.Affiliation;
            if (affiliation is UnionAffiliation)
            {
                UnionAffiliation unionAffiliation = affiliation as UnionAffiliation;
                int memberId = unionAffiliation.MemberId;
                PayrollDatabase.RemoveUnionMember(memberId);
            }
            e.Affiliation = Affiliation;
        }
    }
}
