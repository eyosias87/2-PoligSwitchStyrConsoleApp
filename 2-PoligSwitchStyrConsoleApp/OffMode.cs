namespace _2_PoligSwitchStyrConsoleApp
{
    public class OffMode : BaseMode
    {
        public OffMode() : base("Off") { }

        public override void Execute()
        {
            Console.WriteLine("System is OFF. Pump will not operate.");
        }
    }
}