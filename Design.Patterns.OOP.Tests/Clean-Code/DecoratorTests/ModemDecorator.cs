namespace Design.Patterns.OOP.Tests.Clean_Code.DecoratorTests
{
    public class ModemDecorator : IModem
    {
        protected IModem RealModem;
        public ModemDecorator(IModem realModem) => RealModem = realModem;
        public virtual void Dial(PhoneNumber number) => RealModem.Dial(number);
        public virtual void HangUp() => RealModem.HangUp();
        public virtual void Send(char c) => RealModem.Send(c);

        public virtual char Recv() => RealModem.Recv();
        public virtual void SetSpeakerVolume(int vol) => RealModem.SetSpeakerVolume(vol);
    }
}