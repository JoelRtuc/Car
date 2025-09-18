using Microsoft.VisualBasic.FileIO;
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
        public int distance;
        public bool engineOn;
        public double fuelLevel;
        Fuels fuels;

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
            if (engineOn && fuelLevel > 0)
            {
                Console.WriteLine("Vroom Vroom! " + fuelLevel);
                fuelLevel -= horsePower * 0.01;
                distance += maxSpeed;
            }
            else
            {
                Console.WriteLine("Start the engine first!");
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Brand: {brand}, Color: {color}, Max Speed: {maxSpeed} km/h, Horse Power: {horsePower} HP, Engine On: {engineOn}, Fuel Level: {fuelLevel} L, Fuel Type: {fuels}");
        }

        public Car(string brand = "Unknown", string color = "silver", int maxSpeed = 50, int horsePower = 100, bool engineOn = false, double fuelLevel = 0, Fuels fuelType = Fuels.Gasoline)
        {
            this.brand = brand;
            this.color = color;
            this.maxSpeed = maxSpeed;
            this.horsePower = horsePower;
            this.engineOn = engineOn;
            this.fuelLevel = fuelLevel;
            fuels = fuelType;
        }
        
    }
}
