namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using WarMachines.Interfaces;

    public class Pilot :  IPilot
    {
        private string name;

        IList<IMachine> machines;

        public Pilot(string initialName)
        {
            this.name = initialName;
            this.machines = new List<IMachine>();
        }

        public string Name 
        {
            get
            {
                if (String.IsNullOrEmpty(this.name))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }
                return this.name;
            }
        }

        public void AddMachine(IMachine machine)
        {
            if (String.IsNullOrEmpty(machine.ToString()))
            {
                throw new ArgumentNullException("Machine cannot be null");
            }
            this.machines.Add(machine);
        }

        public string Report()
        {
            var reportPrint = new StringBuilder();
            var numberOfMachinesToString = this.machines.Count == 0 ? "no" : this.machines.Count.ToString();
            var singleOrPluralMachines = this.machines.Count == 1 ? "machine" : "machines";

            reportPrint.AppendLine(string.Format("{0} - {1} {2}", this.Name, numberOfMachinesToString, singleOrPluralMachines));

            foreach (var machine in this.machines)
            {
                reportPrint.AppendLine(machine.ToString());
            }

            return reportPrint.ToString().TrimEnd();
        }
    }
}
