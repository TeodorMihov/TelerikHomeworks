using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyEcosystem
{
    public class Boar : Animal, IHerbivore, ICarnivore, IOrganism
    {
        private const int InitialSize = 4;
        private const int BiteSize = 2;

        public Boar(string name, Point location)
            : base(name, location, InitialSize)
        {

        }

        public int EatPlant(Plant plant)
        {
            if (plant != null)
            {
                this.Size++;
                return plant.GetEatenQuantity(BiteSize);
            }

            return 0;
        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal != null)
            {
                if (InitialSize >= animal.Size)
                {
                    return animal.GetMeatFromKillQuantity();
                }
            }

            return 0;
        }
    }
}
