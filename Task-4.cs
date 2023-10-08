using System;

namespace Task_2_Project
{
    class Program
    {
        public static string CustomTrimStart(string word)
        {
            char[] arr = new char[word.Length];
            int j = 0;

            arr[0] = ' '; 

            for (int i = 0; i < word.Length; i++)
            {
                if (arr[0] == 0 || arr[0] == 32)
                {
                    arr[0] = word[i];
                }
                else if (arr[0] != 0 && arr[0] != 32)
                {
                    arr[j] = word[i];
                    j++;
                }
            }

            string response = new string(arr, 0, j);
            return response;
        }

        public static string CustomTrimEnd(string word)
        {
            char[] arr = new char[word.Length];
            int j = 0;

            arr[0] = ' ';

            for (int i = word.Length - 1; i >= 0; i--)
            {
                if (arr[0] == 0 || arr[0] == 32)
                {
                    arr[0] = word[i];
                }
                else if (arr[0] != 0 && arr[0] != 32)
                {
                    arr[j] = word[i];
                    j++;
                }
            }

            string response1 = new string(arr, 0, j);
            return response1;
        }

        public static string CustomTrim(string word)
        {
            string request = CustomTrimStart(word);
            string response = CustomTrimEnd(request);
            return response;
        }

        public static void Main(string[] args)
        {
            string word = "Salam";
            string response = CustomTrimEnd(word);

            Console.WriteLine(response);

            // TODO: Implement Functionality Here

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
