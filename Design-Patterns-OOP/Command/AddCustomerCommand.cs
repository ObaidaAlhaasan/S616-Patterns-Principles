using Design_Patterns_OOP.Command.Framework;

namespace Design_Patterns_OOP.Command
{
    public class AddCustomerCommand : ICommand
    {
        private CustomerService _customerService;

        public AddCustomerCommand(CustomerService customerService)
        {
            _customerService = customerService;
        }

        public void Execute()
        {
            _customerService.AddCustomer();
        }
    }
}