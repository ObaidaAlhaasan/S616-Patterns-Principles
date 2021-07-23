namespace Design_Patterns_OOP.Bridge
{
    public class BDemo
    {
        public static void Show()
        {
            var remoteControl = new RemoteControl(new SamsungTv());
            remoteControl.turnOn();
            remoteControl.SetChannel(10);
            remoteControl.turnOff();

            var advancedRemote = new AdvancedRemoteControl(new SonyTv());
            advancedRemote.turnOn();
            advancedRemote.SetChannel(2);
            advancedRemote.turnOff();
        }
    }
}