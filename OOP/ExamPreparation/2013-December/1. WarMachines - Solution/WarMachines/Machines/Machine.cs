namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using WarMachines.Interfaces;

    public abstract class Machine : IMachine
    {
        private string name;
        private double healthPoints;
        protected double attackPoints;
        protected double defensePoints;
        private IPilot pilot;
        private IList<string> targets;

        public Machine(string initialName, double initialHealthPoints, double initialAttackPoints, double initialDefensePoints)
        {
            this.Name = initialName;
            this.HealthPoints = initialHealthPoints;
            this.attackPoints = initialAttackPoints;
            this.defensePoints = initialDefensePoints;
            this.targets = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Machine name cannot be null or empty");
                }

                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                if (String.IsNullOrEmpty(value.ToString()))
                {
                    throw new ArgumentNullException("Pilot name cannot be null or empty");
                }

                this.pilot = value;
            }
        }

        public double HealthPoints { get; set; }

        public double AttackPoints 
        { 
            get
            {
                return this.attackPoints;
            }
        }

        public double DefensePoints 
        { 
            get
            {
                return this.defensePoints;
            }
        }

        public System.Collections.Generic.IList<string> Targets
        {
            get 
            {
                if (targets == null)
                {
                    throw new ArgumentNullException("Targets cannot be null");
                }

                return new List<string>(this.targets);
            }
        }

        public void Attack(string target)
        {
            this.targets.Add(target);
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            var targetsToString = this.Targets.Count == 0 ? "None" : string.Join(", ",this.Targets);
            
            result.AppendLine(string.Format("- {0}", this.Name));
            result.AppendLine(string.Format(" *Type: {0}", this.GetType().Name));
            result.AppendLine(string.Format(" *Health: {0}", this.HealthPoints));
            result.AppendLine(string.Format(" *Attack: {0}", this.AttackPoints));
            result.AppendLine(string.Format(" *Defense: {0}",this.DefensePoints));
            result.AppendLine(string.Format(" *Targets: {0}", targetsToString));

            return result.ToString();
        }
    }
}
