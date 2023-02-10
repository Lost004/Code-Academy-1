using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("N ededi daxil edin");
            //string num1 = Console.ReadLine();
            //var num = Convert.ToInt32(num1);
            //if (num % 3 == 0 && num % 7 ==0 )
            //{
            //    Console.WriteLine("Dogrudur");

            //}
            //else
            //{
            //    Console.WriteLine("Yanlisdir");
            //} 


            //Console.WriteLine("N ededi daxil edin");
            //string num1 = Console.ReadLine();
            //var num = Convert.ToInt32(num1);

            //Console.WriteLine("M ededi daxil edin");
            //string num1= Console.ReadLine();
            //nu1= Convert.ToInt32(num1);
            //var sum = 0;

            //if (num % 2 == 0 && num % 2 == 0)
            //{
            //    sum = num1 + nu

            //}
            //else
            //{
            //    Console.WriteLine("Cut deyil");
            //}

            //var count = 0;
            //Console.WriteLine("N ededi daxil edin");
            //var nstr1 = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("M ededi daxil edin");
            //int nstr2 = Convert.ToInt32(Console.ReadLine());



            //for (int i = nstr1; i < nstr2; i++)
            //{
            //    if (i % 2 != 0)

            //  count++;
            //}

            //Console.WriteLine(count);

            //var sum = 0;

            //int[] array1 = { 1, 4, 4, 9, 5, 3 };
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    if (array1[i] % 2 == 0)
            //        sum += array1[i];
            //}
            //Console.WriteLine(sum);
            

            var sum = 0;
            int[] array1 = {12,7,9,4,3};
            for (int i = 0; i < array1.Length; i++) 
            {
              for (int j = 2; j < array1[i]; j++)
                {

                    if (array1[i]%j==0)
                    {
                        sum += array1[i];
                        break;
                    }
                    
                }
               

            }
          
            Console.WriteLine(sum);
















        }
    }
}
