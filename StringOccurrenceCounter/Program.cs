using System;

namespace StringOccurrenceCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую строку: ");
            string str1 = Console.ReadLine();

            Console.Write("Введите вторую строку: ");
            string str2 = Console.ReadLine();

            int count = CountOccurrences(str1, str2);

            Console.WriteLine($"\nРезультат: {count}");
        }

        public static int CountOccurrences(string mainString, string searchString)
        {
            if (string.IsNullOrEmpty(searchString))
                return 0;

            int count = 0;
            int index = 0;

            while ((index = mainString.IndexOf(searchString, index)) != -1)
            {
                count++;
                index += searchString.Length;
            }

            return count;
        }
    }
}
