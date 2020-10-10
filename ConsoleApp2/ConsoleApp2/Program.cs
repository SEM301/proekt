using System;

namespace ConsoleApp2
{ class user
    {   
        public string name = Console.ReadLine();
        private int age =Convert.ToInt32(Console.ReadLine());
        protected string status = "active";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите своё имя и возраст");
            user one =new user();
            Console.WriteLine(one.name);
            Console.ReadLine();
        }
    }
}
