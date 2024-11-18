namespace _2_PoligSwitchStyrConsoleApp
{
    public abstract class BaseMode
    {
        public string ModeName { get; private set; }

        protected BaseMode(string modeName)
        {
            ModeName = modeName;
        }

        // Kör logik baserat på sensorer eller manuella kommandon
        public abstract void Execute();
    }
}