using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyEcosystem
{
    public class Lion : Animal, ICarnivore, IOrganism
    {
        private const int InitialSize = 6;

        public Lion(string name, Point location)
            : base(name, location, InitialSize)
        {

        }

        public int TryEatAnimal(Animal animal)
        {
            int sizeToEat = this.Size * 2;

            if (animal != null)
            {
                if (sizeToEat >= animal.Size)
                {
                    this.Size++;
                    return animal.GetMeatFromKillQuantity();
                }
            }

            return 0;
        }
    }
}
