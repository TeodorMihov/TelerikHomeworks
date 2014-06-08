namespace WarMachines.Machines
{
    using System.Text;

    using WarMachines.Interfaces;

    public class Tank : Machine, ITank, IMachine
    {
        private const double InitialHealthPoints = 100;
        private const double DefenceModeModifier = 30;
        private const double AttackModeModifier = 40;

        private bool defenseMode;

        public Tank(string initialName, double initialAttackPoints, double initialDefensePoints)
            : base(initialName, InitialHealthPoints, initialAttackPoints, initialDefensePoints)
        {
            ToggleDefenseMode();
        }

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            this.defenseMode = !this.defenseMode;

            if (defenseMode)
            {
                this.defensePoints += DefenceModeModifier;
                this.attackPoints -= AttackModeModifier;
            }
            else
            {
                this.defensePoints -= DefenceModeModifier;
                this.attackPoints += AttackModeModifier;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            var defenseModeToString = this.defenseMode == true ? "ON" : "OFF";
            
            result.Append(base.ToString());
            result.Append(string.Format(" *Defense: {0}",defenseModeToString));

            return result.ToString();
        }
    }
}
