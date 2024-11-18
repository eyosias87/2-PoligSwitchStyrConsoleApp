using System;
namespace _2_PoligSwitchStyrConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa switch-kontroller
            SwitchController switchController = new SwitchController();

            // Sensordata för automatläge
            bool lowSensor = false;
            bool highSensor = false;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Switch Modes: ");
                Console.WriteLine("1. Hand Mode");
                Console.WriteLine("2. Auto Mode");
                Console.WriteLine("3. Off Mode");
                Console.WriteLine("4. Exit");

                Console.Write("Select mode: ");
                string? choice = Console.ReadLine();
                if (string.IsNullOrEmpty(choice))
                {
                    Console.WriteLine("Invalid selection. Try again.");
                    continue;
                }
                switch (choice)
                {
                    case "1":
                        switchController.SetMode(new HandMode());
                        break;
                    case "2":
                        Console.Write("Enter sensor data (low/high): ");
                        Console.WriteLine("Example: low=1, high=0");
                        Console.Write("Low Sensor (1/0): ");
                        lowSensor = Console.ReadLine() == "1";
                        Console.Write("High Sensor (1/0): ");
                        highSensor = Console.ReadLine() == "1";

                        switchController.SetMode(new AutoMode(lowSensor, highSensor));
                        break;
                    case "3":
                        switchController.SetMode(new OffMode());
                        break;
                    case "4":
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid selection. Try again.");
                        continue;
                }

                switchController.Run();
                Console.WriteLine("\nPress any key to return to main menu...");
                Console.ReadKey();
            }
        }
    }
}