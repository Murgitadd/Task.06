




//I couldn't :(







using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string inputSentence = Console.ReadLine();

        string[] words = CollectWords(inputSentence);

        Console.WriteLine("Words in the sentence:");
        PrintWords(words);
    }

    static string[] CollectWords(string sentence)
    {
        return words;
    }

    static int CountWords(string sentence)
    {
        return wordCount;
    }

    static void PrintWords(string[] words)
    {
        for (int i = 0; i < words.Length; i++)
        {
            Console.WriteLine(words[i]);
        }
    }
}
