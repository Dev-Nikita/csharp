using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Name: ");
            string name = Console.ReadLine();
            DateTime birthday;
            Console.Write("Enter Birthday: ");
           birthday = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"Welcome  {name}!");
        }
    }
}
