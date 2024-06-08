using System;

class SwapNumbers
{
    static void Main()
    {
        // Prompt the user to enter the first number
        Console.Write("Enter the first number: ");
        int number1 = int.Parse(Console.ReadLine());

        // Prompt the user to enter the second number
        Console.Write("Enter the second number: ");
        int number2 = int.Parse(Console.ReadLine());

        // Display the numbers before swapping
        Console.WriteLine($"\nBefore swapping: number1 = {number1}, number2 = {number2}");

        // Swap the numbers
        int temp = number1;
        number1 = number2;
        number2 = temp;

        // Display the numbers after swapping
        Console.WriteLine($"After swapping: number1 = {number1}, number2 = {number2}");
    }
}
