using System;


namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Kvadrat();
            Koren();


        }
        public static void Kvadrat()
        {
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a * a;
            Console.WriteLine($"Квадрат числа {a}={b}");
            Console.ReadLine();
        }
        private static void Koren()
        {
            Console.WriteLine("Введите число");
            int c = Convert.ToInt32(Console.ReadLine());
            double d = Math.Sqrt(c);
            Console.WriteLine($"Квадрат числа {c}={d}");
            Console.ReadLine();
        }
    }
}
