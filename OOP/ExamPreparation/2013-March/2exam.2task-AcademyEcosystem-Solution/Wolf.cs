using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyEcosystem
{
    public class Wolf : Animal, IOrganism, ICarnivore
    {
        private const int InitialSize = 4;

        public Wolf(string name, Point location)
            : base(name, location, InitialSize)
        {

        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal != null)
            {
                if (InitialSize >= animal.Size || animal.State == AnimalState.Sleeping)
                {
                    return animal.GetMeatFromKillQuantity();
                }
            }
            return 0;
        }
    }
}
