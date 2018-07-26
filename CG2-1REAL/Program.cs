using System;

namespace CG2_1REAL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your first name? ");
            String firstName = Console.ReadLine();

            Console.Write("What is your last name? ");
            String lastName = Console.ReadLine();

            Console.WriteLine("Hello " + firstName + " " + lastName + "!");
            Console.ReadLine();
        }
    }
}
