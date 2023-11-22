using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterfaces
{
    internal class Smartphone:IConnectable,IRechargeable,IDisplayable
    {
        private string brand;
        private string model;
        private int batteryLevel;
        public Smartphone(string brand,string model)
        {
            this.brand = brand;
            this.model = model;
            this.batteryLevel = 100;
        }

        public void Charges(int minutes)
        {
            if (batteryLevel < 100)
            {
                batteryLevel += minutes;
                Console.WriteLine($"SmartPhone batteery Level increased by {minutes} minutes.");
            }
            else
            {
                Console.WriteLine("SmartPhone Battery is already full");
            }
        }

        public bool Connect()
        {
            Console.WriteLine("Conncecting smartPhone...");
            return true;
        }

        public string Display()
        {
            return $"Smartphone:{brand} {model}-BatteryLevel:{batteryLevel}%";
        }
    }
}
