using System;

namespace Work
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            char[] text = Console.ReadLine()
                                 .ToLower()
                                 .ToCharArray();

            Console.Write("Searching string:  ");
            char[] search = Console.ReadLine()
                                   .ToLower()
                                   .ToCharArray();

            int startIndex = -1;
            bool found = false;

            for (int i = 0; i <= text.Length - search.Length; i++)
            {
                found = true;
                for (int j = 0; j < search.Length; j++)
                {
                    if (text[i + j] != search[j])
                    {
                        found = false;
                        break;
                    }
                }

                if (found)
                {
                    startIndex = i;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine("The string you searched for starts at index: " + startIndex);
            }
            else
            {
                Console.WriteLine("The string you searched for was not found.");
            }
            Console.ReadKey();
        }
    }
}
