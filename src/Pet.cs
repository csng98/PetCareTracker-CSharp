using System;

public class Pet
{
    public string Name { get; set; }
    public string Type { get; set; }
    public DateTime LastFed { get; set; }
    public string Medication { get; set; }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}, Type: {Type}, Last Fed: {LastFed}, Medication: {Medication}");
    }
}
