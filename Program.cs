using System;
using System.Collections.Generic;

class Program
{
    static List<Pet> pets = new List<Pet>();

    static void Main()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nPet Care Tracker");
            Console.WriteLine("1. Add Pet");
            Console.WriteLine("2. View Pets");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    AddPet();
                    break;
                case "2":
                    ViewPets();
                    break;
                case "3":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }

    static void AddPet()
    {
        Pet pet = new Pet();

        Console.Write("Enter pet name: ");
        pet.Name = Console.ReadLine();

        Console.Write("Enter pet type: ");
        pet.Type = Console.ReadLine();

        Console.Write("Enter medication: ");
        pet.Medication = Console.ReadLine();

        pet.LastFed = DateTime.Now;

        pets.Add(pet);
        Console.WriteLine("Pet added successfully!");
    }

    static void ViewPets()
    {
        foreach (var pet in pets)
        {
            pet.PrintInfo();
        }
    }
}
