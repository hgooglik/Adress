using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class Adress
    {
       private string city { get; set; } 
       private string street { get; set; }
       private int nomberOfHouse { get; set; }
        public Adress()
        {
            city = "none";
            street = "none";
            nomberOfHouse = 0;
        }
        public void AddAdress(string cty,string str, int nomber)
        {
            city = cty;
            street = str;
            nomberOfHouse = nomber;
        }
        public void Print()
        {
            Console.WriteLine($"City: {city}  Street: {street} Nomber of house: {nomberOfHouse}");
        }
    }
}
