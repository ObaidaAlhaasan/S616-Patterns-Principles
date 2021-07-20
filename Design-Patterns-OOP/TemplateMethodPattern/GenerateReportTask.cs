using System;

namespace Design_Patterns_OOP.TemplateMethodPattern
{
    public class GenerateReportTask : TaskBase
    {
        public GenerateReportTask(AuditTrail auditTrail) : base(auditTrail)
        {
        }

        protected override void DoExecute()
        {
            Console.WriteLine("Generating a Report");
        }
    }
}