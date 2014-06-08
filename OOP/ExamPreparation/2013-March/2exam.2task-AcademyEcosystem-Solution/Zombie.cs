using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyEcosystem
{
    public class Zombie : Animal, IOrganism
    {
        private const int InitialSize = 0;
        private const int SubmitMeat = 10;

        public Zombie(string name, Point location)
            :base(name,location,InitialSize)
        {

        }

        public override int GetMeatFromKillQuantity()
        {
            return SubmitMeat;
        }
    }
}
