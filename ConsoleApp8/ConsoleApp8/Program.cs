using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            Positive(ref num);
            Console.WriteLine(num);

        }
        static int Positive(ref int num)
        {
            return num *= -1;
        }
        
    }
}
