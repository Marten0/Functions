using System;

namespace FunctionsWithArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "red", "blue", "green" };
            string[] morecolors = { "yellow", "pink", "beige"; "purple" }
            PickRandomColor(colors);
            PickRandomColor(morecolors);        
        }

        private static void PickRandomColor(string[] someArrays)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArrays.Length);
            Console.WriteLine(someArrays[randomIndex]);
        }
    }
}
