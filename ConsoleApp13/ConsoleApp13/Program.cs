using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] contacts = { "Nazim-0705634343" };
            string option;
            do
            {
                Console.WriteLine("\n1.Shexs yarat");
                Console.WriteLine("2.Shexslere bax");
                Console.WriteLine("3.Shexslere gore axtaris et");
                Console.WriteLine("4.Nomrelere gore axtaris et");
                Console.WriteLine("5.Bakcel nomrelerine gore axtaris et");
                Console.WriteLine("0.Menu");

                Console.WriteLine("\nSecim edin!");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        string shexs = Console.ReadLine();
                        Array.Resize(ref contacts, contacts.Length + 1);
                        contacts[contacts.Length - 1] = shexs;
                        break;
                    case "2":
                        for (int i = 0; i < contacts.Length;i++)
                        {
                            Console.WriteLine(contacts[i]);
                        }
                        break;
                    case "3":
                        Console.WriteLine("Shexslerin adinan her hans bir herfni qeyd edin!");
                        string searchPerson = Console.ReadLine();
                        bool IsExit = false;
                        for (
                            int i = 0; i <contacts.Length; i++)
                        {
                            if (contacts[i].ToLower().Contains(searchPerson) || contacts[i].ToUpper().Contains(searchPerson))
                            {
                                Console.WriteLine(contacts[i]);
                                IsExit = true;
                            }
                        }
                        if (IsExit)
                        {
                            Console.WriteLine("Bele bir shexs yoxdur");
                        }
                        break;
                    case "4":
                        Console.WriteLine("nomrelere gore axtaris et");
                        phonnumber: string phoneNumberStr = Console.ReadLine();
                        int phoneNumber;
                        bool IsphoneNumber = int.TryParse(phoneNumberStr, out phoneNumber);
                        if (IsphoneNumber)
                        {
                            for (int i = 0; i <contacts.Length; i++)
                            {
                                if (contacts[i].Contains(phoneNumber.ToString()))
                                {
                                    Console.WriteLine(contacts[i]);

                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nomrenin formatin duzgun daxil ele");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Bakcel nomrelerine gore axtaris et");
                        break;
                    case "0":
                        Console.WriteLine("Proses bitdi");
                        break;
                    default:
                        Console.WriteLine("Secim sehvdir,yeniden daxil edin!");
                        break;
                }



            }
            while (option != "0");
        }

        } 
}
