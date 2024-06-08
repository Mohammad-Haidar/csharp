using System;
using System.Linq;

class TextAnalyzer
{
    static void Main()
    {
        // Prompt the user for a text input
        Console.Write("Enter a paragraph or text: ");
        string inputText = Console.ReadLine();

        // Split the text into words
        string[] words = inputText.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        // Count the total number of words
        int wordCount = words.Length;

        // Calculate the total number of letters in all words
        int totalLetters = words.Sum(word => word.Length);

        // Calculate the average word length
        double averageWordLength = wordCount > 0 ? (double)totalLetters / wordCount : 0;

        // Display the statistics
        Console.WriteLine($"\nText Analysis:");
        Console.WriteLine($"Total number of words: {wordCount}");
        Console.WriteLine($"Average word length: {averageWordLength:F2}");
    }
}
