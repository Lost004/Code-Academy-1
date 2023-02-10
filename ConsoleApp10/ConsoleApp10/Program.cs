using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            var neword2 = Reverse("Nazim");
            Console.WriteLine(neword2);
        }
       
        static string Reverse(string word)
        {
            string newWord = "";
            for (int i = word.Length - 1; i>=0; i--)
            {
                newWord += word[i];
            }
            return newWord;
        }
              
    }
}
