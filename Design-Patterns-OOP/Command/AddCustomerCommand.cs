namespace Design_Patterns_OOP.Command
{
    public class AddCustomerCommand : ICommand
    {
        private CustomerService CustomerService;

        public AddCustomerCommand(CustomerService customerService)
        {
            CustomerService = customerService;
        }

        public void Execute()
        {
            CustomerService.AddCustomer();
        }
    }
}