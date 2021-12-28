using System;

namespace Design_Patterns_OOP.PayrollImp.PaymentSchedules
{
    public abstract class PaymentSchedule
    {
        public abstract DateTime GetPayPeriodStartDate(DateTime date);

        public abstract bool IsPayDate(DateTime date);
    }
}