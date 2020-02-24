using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Adress adress = new Adress();
            Console.WriteLine("Please, enter your city:");
            string City = Console.ReadLine();
            Console.WriteLine("Please, enter your street:");
            string Street = Console.ReadLine();
            Console.WriteLine("Please, enter your nomber of house:");
            int Nomber = Convert.ToInt32(Console.ReadLine());
            adress.AddAdress(City,Street,Nomber);
            adress.Print();
            Console.ReadKey();
        }
    }
}
