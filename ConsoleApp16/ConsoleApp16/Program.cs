using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dogum gununuzu yazin!");
            DateTime date = new DateTime();
            string Dates = Console.ReadLine();
            date = Convert.ToDateTime(Dates);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
