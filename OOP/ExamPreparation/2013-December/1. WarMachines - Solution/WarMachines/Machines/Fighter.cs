namespace WarMachines.Machines
{
    using System.Text;
    using WarMachines.Interfaces;

    public class Fighter : Machine, IFighter
    {
        private const double InitialHealthPoints = 200;

        private bool stealthMode;

        public Fighter(string initialName, double initialAttackPoints, double initialDefensePoints, bool initialStealthMode)
            : base(initialName, InitialHealthPoints, initialAttackPoints, initialDefensePoints)
        {
            this.stealthMode = initialStealthMode;
        }

        public bool StealthMode
        {
            get 
            {
                return this.stealthMode;
            }
        }

        public void ToggleStealthMode()
        {
            this.stealthMode = !this.stealthMode;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            var stealthModeToString = this.stealthMode == true ? "ON" : "OFF";

            result.Append(base.ToString());
            result.Append(string.Format(" *Stealth: {0}",stealthModeToString));

            return result.ToString();
        }
    }
}
