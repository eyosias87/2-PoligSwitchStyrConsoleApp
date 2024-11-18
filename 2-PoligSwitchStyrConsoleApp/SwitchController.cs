using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_PoligSwitchStyrConsoleApp
{
    public class SwitchController
    {
        private BaseMode currentMode;

        public SwitchController()
        {
            // Defaultläge är Off
            currentMode = new OffMode();
        }

        public void SetMode(BaseMode mode)
        {
            currentMode = mode;
            Console.WriteLine($"\nSwitch set to: {currentMode.ModeName}");
        }

        public void Run()
        {
            currentMode.Execute();
        }
    }

}
