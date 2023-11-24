using System;

namespace VirtualPetPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to our pet world!");
            Console.WriteLine("--------------------------------");

            var turbo = new Pet("Turbo","He","Ellie Marie", "Cat","MeowMeow", 0, 0, 0, 0);
            var marve = new Pet("Marve", "He", "Camilla", "Dog","BarkBark", 0, 0, 0, 0);
            var willyWonka = new Pet("Willy Wonka","He", "Bjørn", "Snake", "Szzzz", 0,0,0,0);

            while (true)
            {
                Console.WriteLine("Choose your pet:");
                Console.WriteLine($"1. {turbo.NameOfPet}");
                Console.WriteLine($"2. {marve.NameOfPet}");
                Console.WriteLine($"3. {willyWonka.NameOfPet}");
                Console.WriteLine();
                Console.WriteLine("4. Exit Program");
                Console.WriteLine();


                char petChoice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (petChoice)
                {
                    case '1':
                        InteractWithPet(turbo);
                        break;
                    case '2':
                        InteractWithPet(marve);
                        break;
                    case '3':
                        InteractWithPet(willyWonka);
                        break;
                    case '4':
                        return;
                }
            }
        }

        static void InteractWithPet(Pet pet)
        {
            Console.WriteLine($"You picked {pet.NameOfPet}!");
            Console.WriteLine($"{pet.PetGender} live with his owner {pet.PetsOwner}.");
            Console.WriteLine($"{pet.NameOfPet} is a {pet.Animal}!");
            Console.WriteLine($"{pet.Animal}s makes the sound {pet.AnimalSound}!");
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Choose an option:");
                Console.WriteLine($"1. Feed {pet.NameOfPet}");
                Console.WriteLine($"2. Play with {pet.NameOfPet}");
                Console.WriteLine($"3. Snuggle with {pet.NameOfPet}");
                Console.WriteLine($"4. Make {pet.NameOfPet} go poop");
                Console.WriteLine("5. Just pass the time");
                Console.WriteLine();
                Console.WriteLine($"6. Exit {pet.NameOfPet}'s world");
                Console.WriteLine();


                char choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (choice)
                {
                    case '1':
                        pet.HungerCount = 0;
                        Console.WriteLine($"{pet.NameOfPet} is happy, rolling and fed.");
                        PassTime(pet);
                        var needs1 = PetNeeds(pet);
                        Console.WriteLine(needs1.PetStatus);
                        break;
                    case '2':
                        pet.Boredom = 0;
                        Console.WriteLine("Wohooo, playtime!");
                        PassTime(pet);
                        var needs2 = PetNeeds(pet);
                        Console.WriteLine(needs2.PetStatus);
                        break;
                    case '3':
                        pet.Snuggle = 0;
                        Console.WriteLine("Purr purr, that's good!");
                        PassTime(pet);
                        var needs3 = PetNeeds(pet);
                        Console.WriteLine(needs3.PetStatus);
                        break;
                    case '4':
                        pet.PoopTime = 0;
                        Console.WriteLine("Aww poopie time!");
                        PassTime(pet);
                        var needs4 = PetNeeds(pet);
                        Console.WriteLine(needs4.PetStatus);
                        break;
                    case '5':
                        PassTime(pet);
                        var needs5 = PetNeeds(pet);
                        Console.WriteLine(needs5.PetStatus);
                        break;
                    case '6':
                        Console.WriteLine($"{pet.NameOfPet}'s world is shutting down. {pet.NameOfPet} says ByeBye!");
                        Console.WriteLine();
                        Console.WriteLine("Taking you back to choose your pet");
                        Console.WriteLine();
                        return;
                }
            }
        }


        public static (int HungerCount, int Boredom, int Snuggle, int PoopTime) PassTime(Pet pet)
        {
            Random randomHunger= new Random();
            Random randomBoredom= new Random();
            Random randomSnuggle= new Random();

                       
            pet.HungerCount += randomHunger.Next(1, 10);
            pet.Boredom += randomBoredom.Next(1, 10);
            pet.Snuggle += randomSnuggle.Next(1, 10);

            pet.PoopTime = pet.HungerCount + pet.Boredom + pet.Snuggle;

            return (pet.HungerCount, pet.Boredom, pet.Snuggle, pet.PoopTime);
        }

        public static (int HungerCount, int Boredom, int Snuggle, int PoopTime, string PetStatus) PetNeeds(Pet pet)
        {
            if (pet.HungerCount >= 25)
            {
                return (pet.HungerCount, pet.Boredom, pet.Snuggle, pet.PoopTime, $"{pet.NameOfPet} is hungry!");
            }
            if (pet.Boredom >= 25)
            {
                return (pet.HungerCount, pet.Boredom, pet.Snuggle, pet.PoopTime, $"{pet.NameOfPet} is bored!");
            }
            if (pet.Snuggle >= 25)
            {
                return (pet.HungerCount, pet.Boredom, pet.Snuggle, pet.PoopTime, $"{pet.NameOfPet} wants a snugglebuddy!");
            }
            if (pet.PoopTime >= 50)
            {
                return (pet.HungerCount, pet.Boredom, pet.Snuggle, pet.PoopTime, $"{pet.NameOfPet} needs to poop!");
            }

            return (pet.HungerCount, pet.Boredom, pet.Snuggle, pet.PoopTime, $"{pet.NameOfPet} is good for now, don't need anything");
        }
    }
}
