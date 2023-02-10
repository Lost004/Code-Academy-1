using System;

namespace ConsoleApp15
{
   class Student
    {
        public string Fulname;
        public int point;
        public int GroupNo;
        public bool IsPassed()
        {
            if (point >= 65)
            {
                return true;
            }
        }

    }
  

    class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student();
            Console.WriteLine(std1.IsPassed());
        }
    }
}
