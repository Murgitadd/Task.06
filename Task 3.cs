using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a Sentence: ");
        string sentence = Console.ReadLine();

        int maxWordCount = 2;
        string[] words = new string[maxWordCount];

        int wordCount = 0;
        string currentWord = "";
        bool insideWord = false;

        for (int i = 0; i < sentence.Length; i++)
        {
            char c = sentence[i];

            if (c == ' ')
            {
                if (insideWord)
                {
                    if (wordCount >= maxWordCount)
                    {
                        
                        string[] newWords = new string[maxWordCount * 2];
                        
                        
                        for (int j = 0; j < maxWordCount; j++)
                        {
                            newWords[j] = words[j];
                        }
                        
                        
                        maxWordCount *= 2;
                        
                        
                        words = newWords;
                    }

                    words[wordCount] = currentWord;
                    wordCount++;
                    currentWord = "";
                    insideWord = false;
                }
            }
            else
            {
                currentWord += c;
                insideWord = true;
            }
        }

        if (insideWord)
        {
            if (wordCount >= maxWordCount)
            {
                
                string[] newWords = new string[maxWordCount * 2];
                
               
                for (int j = 0; j < maxWordCount; j++)
                {
                    newWords[j] = words[j];
                }
                
                
                maxWordCount *= 2;
                
                
                words = newWords;
            }

            words[wordCount] = currentWord;
            wordCount++;
        }

        Console.WriteLine("Words in the sentence:");
        for (int i = 0; i < wordCount; i++)
        {
            Console.WriteLine(words[i]);
        }
    }
}
