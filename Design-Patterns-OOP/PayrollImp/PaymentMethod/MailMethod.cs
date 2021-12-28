﻿namespace Design_Patterns_OOP.PayrollImp.PaymentMethod
{
    public class MailMethod : PaymentMethod
    {
        private readonly string address;
        public MailMethod(string address)
        {
            this.address = address;
        }

        public override void Pay(Paycheck paycheck)
        {
            
        }
    }
}