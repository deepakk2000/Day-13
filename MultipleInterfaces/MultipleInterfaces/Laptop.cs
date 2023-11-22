using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterfaces
{
    class Laptop : IRechargeable, IConnectable, IDisplayable
    {
        private string brand;
        private string model;
        private int batteryLevel;
        public Laptop(string brand, string model)
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
                Console.WriteLine($"Laptop batteery Level increased by {minutes} minutes.");
            }
            else
            {
                Console.WriteLine("Laptop Battery is already full");
            }
        }

        public bool Connect()
        {
            Console.WriteLine("Conncecting Laptop...");
            return true;
        }

        public string Display()
        {
            return $"Laptop:{brand} {model}-BatteryLevel:{batteryLevel}%";
        }

    }
}
