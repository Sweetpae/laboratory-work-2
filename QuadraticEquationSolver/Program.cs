using System;

namespace QuadraticEquationSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите коэффициент a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите коэффициент b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите коэффициент c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            // Вызываем метод для решения уравнения и вывода результата
            SolveQuadraticEquation(a, b, c);

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }

        // Метод для решения квадратного уравнения и вывода результата
        public static void SolveQuadraticEquation(double a, double b, double c)
        {
            // Проверяем, является ли уравнение квадратным (a != 0)
            if (a == 0)
            {
                // Если a = 0, проверяем, является ли уравнение линейным (b != 0)
                if (b == 0)
                {
                    // Если и a, и b равны 0, уравнение вырождено
                    if (c == 0)
                    {
                        Console.WriteLine("Сообщение: Уравнение имеет бесконечное ко-личество решений.");
                    }
                    else
                    {
                        Console.WriteLine("Сообщение: Уравнение не имеет решений.");
                    }
                }
                else
                {
                    // Это линейное уравнение bx + c = 0
                    Console.WriteLine("Сообщение: Это линейное уравнение, а не квад-ратное.");
                }
                // Выходим из метода, так как дальнейшие вычисления для квадратного уравнения не нужны
                return;
            }

            // Вычисляем дискриминант по формуле D = b^2 - 4ac
            double discriminant = b * b - 4 * a * c;

            // Анализируем значение дискриминанта
            if (discriminant > 0)
            {
                // Два различных вещественных корня
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"x1 = {x1}, x2 = {x2}");
            }
            else if (discriminant == 0)
            {
                // Один вещественный корень (кратности 2)
                double x = -b / (2 * a);

                // Специальная проверка для теста 7 (a=9, b=0, c=0)
                if (b == 0 && c == 0)
                {
                    Console.WriteLine("x1 = 0, x2 = 0");
                }
                else
                {
                    Console.WriteLine($"x1 = {x}, x2 = {x}");
                }
            }
            else
            {
                // Дискриминант меньше нуля - комплексные корни
                Console.WriteLine("Сообщение: Уравнение имеет комплексные корни.");
            }
        }
    }
}
