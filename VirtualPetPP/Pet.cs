using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPetPP
{
    internal class Pet
    {
        public string NameOfPet { get; set; }
        public string PetGender { get; set; }
        public string PetsOwner { get; set; }
        public string Animal { get; set; }
        public string AnimalSound { get; set; }
        public int HungerCount { get; set; }
        public int Boredom { get; set; }
        public int Snuggle { get; set; }
        public int PoopTime { get; set; }

        public Pet(
            string nameOfPet,
            string petGender,
            string petsOwner,
            string animal,
            string animalSound,
            int hungerCount,
            int boredom,
            int snuggle,
            int poopTime
            )
        {
            NameOfPet = nameOfPet;
            PetGender = petGender;
            PetsOwner = petsOwner;
            Animal = animal;
            AnimalSound = animalSound;
            HungerCount = hungerCount;
            Boredom = boredom;
            Snuggle = snuggle;
            PoopTime = poopTime;
        }
    }
}
