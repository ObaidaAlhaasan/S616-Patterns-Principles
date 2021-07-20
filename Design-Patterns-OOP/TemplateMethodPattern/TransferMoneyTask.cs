using System;

namespace Design_Patterns_OOP.TemplateMethodPattern
{
    public class TransferMoneyTask : TaskBase
    {
        public TransferMoneyTask(AuditTrail auditTrail) : base(auditTrail)
        {
        }

        protected override void DoExecute() => Console.WriteLine("Transfer Money");
    }
}