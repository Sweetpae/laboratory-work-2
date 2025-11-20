using System;

namespace ArrayGCD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива N: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            Console.WriteLine($"\nВведите {n} натуральных чисел:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"A[{i + 1}]: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"\nВведенный массив: [{string.Join(", ", array)}]");

            int gcd = FindArrayGCD(array);
            Console.WriteLine($"Наибольший общий делитель всех элементов: {gcd}");

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

        // Метод для нахождения НОД двух чисел (алгоритм Евклида)
        public static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Метод для нахождения НОД всего массива
        public static int FindArrayGCD(int[] array)
        {
            if (array == null || array.Length == 0)
                return 0;

            int result = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                result = GCD(result, array[i]);

                // Если НОД стал 1, дальше можно не проверять
                if (result == 1)
                    break;
            }
            return result;
        }
    }
}
