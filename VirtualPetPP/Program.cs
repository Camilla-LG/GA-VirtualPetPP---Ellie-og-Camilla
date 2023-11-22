using System;

namespace VirtualPetPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to our pet world!");
            Console.WriteLine("--------------------------------");

            var turbo = new Pet("Turbo", "Cat", 0, 0, 0, false);
            var marve = new Pet("Marve", "Dog", 0, 0, 0, false);

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
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Feed");
                Console.WriteLine("2. Play");
                Console.WriteLine("3. Snuggle");
                Console.WriteLine("4. Check if pet needs to poop");
                Console.WriteLine();
                Console.WriteLine("5. Exit pet world");

                char choice = Console.ReadKey().KeyChar;

                switch (choice)
                {
                    case '1':
                        Console.WriteLine($"{pet.Name} is happy, rolling and fed.");
                        break;
                    case '2':
                        Console.WriteLine("Wohooo, playtime!");
                        break;
                    case '3':
                        Console.WriteLine("Purr purr, that's good!");
                        // Kan legge inn en if for høyre eller venstre
                        break;
                    case '4':
                        Console.WriteLine("Poopie");
                        pet.PoopTime = PoopieTime(pet.PoopTime);
                        break;
                    case '5':
                        Console.WriteLine("Pet world is shutting down. Byebye!");
                        return;
                }
            }
        }

        public static bool PoopieTime(bool currentPoopieTime)
        {
            return !currentPoopieTime;
        }

        // Legge til "PassTime()" metode med random funksjonalitet.
    }
}
