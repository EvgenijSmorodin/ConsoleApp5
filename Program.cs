using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Иванов";
            string surname = "Иван";
            Console.WriteLine($"Ваше имя {name}, фамилия {surname}");
            string name1;
            name1 = name;
            name = surname;
            surname = name1;
            Console.WriteLine($"Ваше имя {name}, фамилия {surname}");
        }
    }
}
