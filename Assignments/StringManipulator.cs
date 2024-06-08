using System;

class StringManipulator
{
    static void Main()
    {
        // Prompt the user for a string input
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        // Remove leading and trailing whitespace characters
        string trimmedString = inputString.Trim();
        Console.WriteLine($"Trimmed string: \"{trimmedString}\"");

        // Ask the user if they want to convert the string to uppercase or lowercase
        Console.Write("Do you want to convert the string to (U)ppercase or (L)owercase? ");
        char choice = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine(); // Move to the next line

        string modifiedString;
        if (choice == 'U')
        {
            modifiedString = trimmedString.ToUpper();
        }
        else if (choice == 'L')
        {
            modifiedString = trimmedString.ToLower();
        }
        else
        {
            Console.WriteLine("Invalid choice. Exiting the program.");
            return;
        }

        Console.WriteLine($"Modified string: \"{modifiedString}\"");

        // Prompt the user for start and end indices for substring extraction
        Console.Write("Enter the start index for the substring: ");
        int startIndex = int.Parse(Console.ReadLine());

        Console.Write("Enter the end index for the substring: ");
        int endIndex = int.Parse(Console.ReadLine());

        // Validate indices and extract substring
        if (startIndex >= 0 && endIndex < modifiedString.Length && startIndex <= endIndex)
        {
            string substring = modifiedString.Substring(startIndex, endIndex - startIndex + 1);
            Console.WriteLine($"Extracted substring: \"{substring}\"");
        }
        else
        {
            Console.WriteLine("Invalid indices. Please make sure the indices are within the valid range and start index is less than or equal to end index.");
        }
    }
}
