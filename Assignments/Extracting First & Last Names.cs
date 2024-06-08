using System;

class Program
{
    static void Main()
    {
        // Prompt the user for their full name
        Console.Write("Please enter your full name: ");
        string fullName = Console.ReadLine();

        // Split the full name into parts
        string[] nameParts = fullName.Split(' ');

        // Extract the first and last name
        string firstName = nameParts[0];
        string lastName = nameParts[nameParts.Length - 1];

        // Display the first and last names
        Console.WriteLine($"First Name: {firstName}");
        Console.WriteLine($"Last Name: {lastName}");
    }
}
