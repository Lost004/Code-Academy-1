using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 12, 45, 64, 78 };
            var result = naz(64, numbers);
            Console.WriteLine(result);

        }
        static string Reverse(string str)
        {
            string newstr = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                newstr += str[i];
            }

            return newstr;
        }
        static int Naz(string text, char cr)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)

            {
                if (text[i] == cr)
                    count++;
            }
            return count;
        }
        static int naz(int num1, int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num1)
                    return i;
            }
            return -1;
        }
        static string FirstWord(string text)
        {
            
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                    break;
                

            }
            

            
        }
    }
}
