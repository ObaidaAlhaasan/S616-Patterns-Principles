namespace Design_Patterns_OOP.Bridge
{
    public class AdvancedRemoteControl
    {
        private IDevice _device;

        public AdvancedRemoteControl(IDevice device)
        {
            _device = device;
        }

        public void turnOn()
        {
            _device.TurnOn();
        }

        public void turnOff()
        {
            _device.TurnOff();
        }

        public void SetChannel(int num)
        {
            _device.SetChannel(num);
        }
    }
}