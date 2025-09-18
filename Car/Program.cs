namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.brand = "Jeep";
            myCar.color = "Red";
            myCar.maxSpeed = 50;
            myCar.horsePower = 300;
            myCar.fuelLevel = 20;
            myCar.engineOn = false;

            Console.WriteLine("Start Engine? (yes/no)");
            if (Console.ReadLine().ToLower() == "yes")
            {
                myCar.StartEngine();
            }
            else
            {
                Environment.Exit(0);
            }

            if (myCar.fuelLevel <= 0)
            {
                Console.WriteLine("Out of fuel! You made it " + myCar.distance + " km");
            }

            myCar.ShowInfo();

            while (myCar.fuelLevel > 0 && myCar.engineOn)
            {
                myCar.Drive();
            }
        }
    }

    
}
