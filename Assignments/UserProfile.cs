using System;

class UserProfile
{
    static void Main()
    {
        // Collect user's name
        Console.Write("Enter your full name: ");
        string fullName = Console.ReadLine();

        // Collect user's email
        Console.Write("Enter your email: ");
        string email = Console.ReadLine();

        // Collect user's phone number
        Console.Write("Enter your phone number: ");
        string phoneNumber = Console.ReadLine();

        // Display the collected user profile
        Console.WriteLine("\nUser Profile:");
        Console.WriteLine($"Name: {fullName}");
        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"Phone Number: {phoneNumber}");
    }
}
