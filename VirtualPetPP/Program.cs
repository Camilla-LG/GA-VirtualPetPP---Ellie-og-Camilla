using System;

namespace VirtualPetPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to our pet world!");
            Console.WriteLine("--------------------------------");

            var turbo = new Pet("Turbo", "Cat", 0, 0, 0, 0);
            var marve = new Pet("Marve", "Dog", 0, 0, 0, 0);

            while (true)
            {
                Console.WriteLine("Choose your pet:");
                Console.WriteLine("1. Turbo");
                Console.WriteLine("2. Marve");

                char petChoice = Console.ReadKey().KeyChar;

                switch (petChoice)
                {
                    case '1':
                        Console.WriteLine("You picked Turbo!");
                        InteractWithPet(turbo);
                        break;
                    case '2':
                        Console.WriteLine("You picked Marve!");
                        InteractWithPet(marve);
                        break;
                }
            }
        }

        static void InteractWithPet(Pet pet)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Feed");
                Console.WriteLine("2. Play");
                Console.WriteLine("3. Snuggle");
                Console.WriteLine("4. Check if pet needs to poop");
                Console.WriteLine();
                Console.WriteLine("5. Exit pet world");

                char choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (choice)
                {
                    case '1':
                        PassTime(pet);
                        pet.HungerCount = 0;
                        Console.WriteLine($"{pet.Name} is happy, rolling and fed.");
                        var needs1 = PetNeeds(pet);
                        Console.WriteLine(needs1.PetStatus);
                        needs1.PetStatus = "";
                        break;
                    case '2':
                        PassTime(pet);
                        pet.Boredom = 0;
                        Console.WriteLine("Wohooo, playtime!");
                        var needs2 = PetNeeds(pet);
                        Console.WriteLine(needs2.PetStatus);
                        needs2.PetStatus = "";
                        break;
                    case '3':
                        PassTime(pet);
                        pet.Snuggle = 0;
                        Console.WriteLine("Purr purr, that's good!");
                        var needs3 = PetNeeds(pet);
                        Console.WriteLine(needs3.PetStatus);
                        needs3.PetStatus = "";
                        // Kan legge inn en if for høyre eller venstre
                        break;
                    case '4':
                        PassTime(pet);
                        pet.PoopTime = 0;
                        Console.WriteLine("Poopie");
                        var needs4 = PetNeeds(pet);
                        Console.WriteLine(needs4.PetStatus);
                        needs4.PetStatus = "";
                        break;
                    case '5':
                        Console.WriteLine("Pet world is shutting down. Byebye!");
                        return;
                }
            }
        }


        // Legge til "PassTime()" metode med random funksjonalitet.
        public static (int HungerCount, int Boredom, int Snuggle, int PoopTime) PassTime(Pet pet)
        {
            Random randomHunger= new Random();
            Random randomBoredom= new Random();
            Random randomSnuggle= new Random();

                       
            pet.HungerCount += randomHunger.Next(1, 5);
            pet.Boredom += randomBoredom.Next(1, 5);
            pet.Snuggle += randomSnuggle.Next(1, 5);

            pet.PoopTime = pet.HungerCount + pet.Boredom + pet.Snuggle;

            return (pet.HungerCount, pet.Boredom, pet.Snuggle, pet.PoopTime);
        }

        public static (int HungerCount, int Boredom, int Snuggle, int PoopTime, string PetStatus) PetNeeds(Pet pet)
        {
            if (pet.HungerCount <= 10)
            {
                return (pet.HungerCount, pet.Boredom, pet.Snuggle, pet.PoopTime, "Pet is hungry!");
            }
            if (pet.Boredom <= 10)
            {
                return (pet.HungerCount, pet.Boredom, pet.Snuggle, pet.PoopTime, "Pet is bored!");
            }
            if (pet.Snuggle <= 10)
            {
                return (pet.HungerCount, pet.Boredom, pet.Snuggle, pet.PoopTime, "Pet wants a snugglebuddy!");
            }
            if (pet.PoopTime <= 15)
            {
                return (pet.HungerCount, pet.Boredom, pet.Snuggle, pet.PoopTime, "Pet needs to poop!");
            }

            // If HungerCount is not 10, return other values with an empty string
            return (pet.HungerCount, pet.Boredom, pet.Snuggle, pet.PoopTime, string.Empty);
        }
    }
}
