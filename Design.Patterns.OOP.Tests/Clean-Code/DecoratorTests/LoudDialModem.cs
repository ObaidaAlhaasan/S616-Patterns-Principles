namespace Design.Patterns.OOP.Tests.Clean_Code.DecoratorTests
{
    public class LoudDialModem : ModemDecorator
    {
        public LoudDialModem(IModem realModem) : base(realModem)
        {
        }

        public override void Dial(PhoneNumber number)
        {
            RealModem.SetSpeakerVolume(10);
            RealModem.Dial(number);
        }
    }
}