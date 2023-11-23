using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetPP
{
    internal class Pet
    {
        public string Name { get; set; }
        public string Animal { get; set; }
        public int HungerCount { get; set; }
        public int Boredom { get; set; }
        public int Snuggle { get; set; }
        public int PoopTime { get; set; }

        public Pet(
            string name,
            string animal,
            int hungerCount,
            int boredom,
            int snuggle,
            int poopTime
            )
        {
            Name = name;
            Animal = animal;
            HungerCount = hungerCount;
            Boredom = boredom;
            Snuggle = snuggle;
            PoopTime = poopTime;
        }
    }
}
