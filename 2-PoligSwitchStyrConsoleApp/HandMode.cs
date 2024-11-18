namespace _2_PoligSwitchStyrConsoleApp
{
    public class HandMode : BaseMode
    {
        public HandMode() : base("Hand") { }

        public override void Execute()
        {
            Console.WriteLine("Hand mode activated. Use manual controls to operate the pump.");
            Console.WriteLine("Press 'S' to start the pump, 'T' to stop the pump.");

            while (true)
            {
                char command = Console.ReadKey().KeyChar;

                if (command == 'S' || command == 's')
                {
                    Console.WriteLine("\nPump started manually.");
                }
                else if (command == 'T' || command == 't')
                {
                    Console.WriteLine("\nPump stopped manually.");
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid command. Use 'S' to start or 'T' to stop.");
                }
            }
        }
    }
}