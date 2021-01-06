using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Ravnostoron(2,2,2));  // Является ли треугольник равносторонним
            Console.WriteLine(Ravnobedr(4, 2, 2));  // Является ли треугольник равнобедренным
            Console.WriteLine(Raznostoron(4, 3, 2));    // Является ли треугольник разносторонним
        }
        public static double Ravnostoron(double a, double b, double c)
        {
            if ((a == b) & (b == c) & (a == c))
            {
                return 1;   // Треугольник равносторонний

            }
            else return 0;

        }
        public static double Ravnobedr(double a, double b, double c)
        {
            if ((a == b) | (b == c) | (a == c))
            {
                return 1;   // Треугольник равнобедренный

            }
            else return 0;

        }
        public static double Raznostoron(double a, double b, double c)
        {
            if ((a != b) & (b != c) & (a != c))
            {
                return 1;   // Треугольник разносторонний

            }
            else return 0;

        }
    }
}
