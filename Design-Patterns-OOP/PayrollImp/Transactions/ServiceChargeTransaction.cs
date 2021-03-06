using System;
using Design_Patterns_OOP.PayrollImp.UnionMember;

namespace Design_Patterns_OOP.PayrollImp.Transactions
{
    public class ServiceChargeTransaction
    {
        private readonly int memberId;
        private readonly DateTime time;
        private readonly double charge;
        public ServiceChargeTransaction(int id, DateTime time, double charge)
        {
            this.memberId = id;
            this.time = time;
            this.charge = charge;
        }
        public void Execute()
        {
            Employee e = PayrollDatabase.GetUnionMember(memberId);
            if (e != null)
            {
                UnionAffiliation ua = null;
                if (e.Affiliation is UnionAffiliation)
                    ua = e.Affiliation as UnionAffiliation;
                if (ua != null)
                    ua.AddServiceCharge(memberId, new ServiceCharge(time, charge));
                else
                    throw new InvalidOperationException("Tries to add service charge to union member without a union affiliation");
            }
            else
                throw new InvalidOperationException("No such union member.");
        }
    }
}
