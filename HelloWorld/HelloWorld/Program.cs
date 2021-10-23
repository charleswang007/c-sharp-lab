using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            Console.WriteLine($"\nHello {name}!");
            Console.WriteLine("Hello World!");

            DateTime now = DateTime.Now;
            int dayOfYear = now.DayOfYear;
            Console.Write("Day of year: ");
            Console.WriteLine(dayOfYear);
        }
    }
}
