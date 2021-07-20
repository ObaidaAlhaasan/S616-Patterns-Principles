namespace Design_Patterns_OOP.TemplateMethodPattern
{
    public abstract class TaskBase
    {
        private AuditTrail AuditTrail { get; set; }

        public TaskBase(AuditTrail auditTrail)
        {
            AuditTrail = auditTrail;
        }

        public void Execute()
        {
            AuditTrail.Record();
            DoExecute();
        }

        protected abstract void DoExecute();
    }
}