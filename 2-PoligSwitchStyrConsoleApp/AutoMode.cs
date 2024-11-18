namespace _2_PoligSwitchStyrConsoleApp
{
    public class AutoMode : BaseMode
    {
        private bool lowSensor;
        private bool highSensor;

        public AutoMode(bool lowSensor, bool highSensor) : base("Auto")
        {
            this.lowSensor = lowSensor;
            this.highSensor = highSensor;
        }

        public override void Execute()
        {
            Console.WriteLine("Auto mode activated. Pump operates based on sensor input.");

            if (lowSensor)
            {
                Console.WriteLine("Low level detected. Pump started automatically.");
            }
            else if (highSensor)
            {
                Console.WriteLine("High level detected. Pump stopped automatically.");
            }
            else
            {
                Console.WriteLine("No valid sensor input detected. Pump remains off.");
            }
        }
    }
}