namespace Design.Patterns.OOP.Tests.Clean_Code.DecoratorTests
{
    public class QuiteDialModem : ModemDecorator
    {
        public QuiteDialModem(IModem realModem) : base(realModem)
        {
        }

        public override void Dial(PhoneNumber number)
        {
            RealModem.SetSpeakerVolume(0);
            RealModem.Dial(number);
        }
    }
}