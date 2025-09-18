using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class Car
    {
        public string brand;
        public string color;
        public int maxSpeed;
        public int horsePower;
        public bool engineOn;
        public double fuelLevel;

        public enum Fuels
        {
            Gasoline,
            Diesel,
            Electric,
            Hybrid
        }

        public void Honk()
        {
            Console.WriteLine("Beep Beep!");
        }

        public void StartEngine()
        {
            if (!engineOn)
            {
                engineOn = true;
                Console.WriteLine("Engine started.");
            }
            else
            {
                Console.WriteLine("Engine is already on.");
            }
        }

        public void Drive()
        {
            if (engineOn)
            {
                Console.WriteLine("Vroom Vroom!");
            }
            else
            {
                Console.WriteLine("Start the engine first!");
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Brand: {brand}, Color: {color}, Max Speed: {maxSpeed} km/h, Horse Power: {horsePower} HP, Engine On: {engineOn}, Fuel Level: {fuelLevel} L");
        }

        public Car(string brand = "Unknown", string color = "silver", int maxSpeed = 50, int horsePower = 100, bool engineOn = false, double fuelLevel = 0)
        {
            this.brand = brand;
            this.color = color;
            this.maxSpeed = maxSpeed;
            this.horsePower = horsePower;
            this.engineOn = engineOn;
            this.fuelLevel = fuelLevel;
        }
        
    }
}
