
using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta oma sünniaasta");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta oma perekonnanimi");
            string lastName = Console.ReadLine();

            Greetings(userName, userAge, lastName);
        }

        private static void Greetings(string someString,int someInt, string someName)
        {
            Console.WriteLine($"Tere, {someString} {someName}!");
            Console.WriteLine($"Oled {2021 - someInt}");
        }
    }
}
