using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone("Poco","M2");
            Laptop laptop = new Laptop("Lenovo","Gen10");
            Console.WriteLine("SmartPhone connected:" + smartphone.Connect());
            Console.WriteLine("Laptop connected:" + laptop.Connect());
            smartphone.Charges(30);
            laptop.Charges(60);
            Console.WriteLine("Smartphone info:"+smartphone.Display());
            Console.WriteLine("Laptop info:" + laptop.Display());

        }
    }
}
