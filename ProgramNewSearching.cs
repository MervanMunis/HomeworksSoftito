using System;

namespace Work
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            string text = Console.ReadLine().ToLower();

            Console.Write("Searching string: ");
            string search = Console.ReadLine().ToLower();

            int textLength = text.Length;
            int searchLength = search.Length;

            int i = 0; // Metin konumu
            int j = 0; // Aranan metin konumu

            while (i < textLength)
            {
                if (text[i] == search[j])
                {
                    j++;
                    if (j == searchLength) // Burada aranan metin uzunluğu ile konum değeri eşit ise search tamamlanır.
                    {
                        Console.WriteLine("The string you searched for starts at index: " + (i - j + 1));
                        return;
                    }
                }
                else
                {
                    i -= j; 
                    j = 0;
                }
                i++;
            }

            Console.WriteLine("The string you searched for was not found.");
        }
    }
}