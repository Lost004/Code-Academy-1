using System;

namespace ConsoleApp14
{

    class Human
    {
        public string Name;
        public string surname;
        public byte age;


        public void GetFullname()
        {
            Console.WriteLine($"Name: {Name}-surname: {surname}");
        }



}
class Program
{

    static void Main(string[] args)
    {
            Human std1 = new Human()
            {
                Name = "Nazim",
                surname = "Ibrahimov",
                age = 18,


            };
            std1 human     
    }
}
}
