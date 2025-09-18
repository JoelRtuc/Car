namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(), theirCar = new Car();
            int choice;
            Console.WriteLine("What car do you want\n1. Ferrari\n2. Jeep\n3. Volvo\n4. Lada\n5. Tesla");
            int.TryParse(Console.ReadLine(), out choice );

            choice--;

            switch (choice)
            {
                case 0:
                    Console.WriteLine("You chose Ferrari");
                    myCar = new Car("Ferrari", "yellow", 150, 100, 20, Car.Fuels.Hybrid);
                    break;
                case 1:
                    Console.WriteLine("You chose Jeep");
                    myCar = new Car("Jeep", "Red", 50, 300, 100, Car.Fuels.Gasoline);
                    break;
                case 2:
                    Console.WriteLine("You chose Volvo");
                    myCar = new Car("Volvo", "Silver", 75, 150, 50, Car.Fuels.Hybrid);
                    break;
                case 3:
                    Console.WriteLine("You chose Lada");
                    myCar = new Car("Lada", "White", 60, 50, 100, Car.Fuels.Diesel);
                    break;
                case 4:
                    Console.WriteLine("You chose Tesla");
                    myCar = new Car("Tesla", "Black", 100, 100, 75, Car.Fuels.Electric);
                    break;
            }

            Console.WriteLine("What car do you want to go against?\n1. Ferrari\n2. Jeep\n3. Volvo\n4. Lada\n5. Tesla");
            int.TryParse(Console.ReadLine(), out choice);

            choice--;

            switch (choice)
            {
                case 0:
                    Console.WriteLine("You chose Ferrari");
                    theirCar = new Car("Ferrari", "yellow", 150, 100, 20, Car.Fuels.Hybrid);
                    break;
                case 1:
                    Console.WriteLine("You chose Jeep");
                    theirCar = new Car("Jeep", "Red", 50, 300, 100, Car.Fuels.Gasoline);
                    break;
                case 2:
                    Console.WriteLine("You chose Volvo");
                    theirCar = new Car("Volvo", "Silver", 75, 150, 50, Car.Fuels.Hybrid);
                    break;
                case 3:
                    Console.WriteLine("You chose Lada");
                    theirCar = new Car("Lada", "White", 60, 50, 100, Car.Fuels.Diesel);
                    break;
                case 4:
                    Console.WriteLine("You chose Tesla");
                    theirCar = new Car("Tesla", "Black", 100, 100, 75, Car.Fuels.Electric);
                    break;
            }

            Console.WriteLine("Start Engine? (yes/no)");
            if (Console.ReadLine().ToLower() == "yes")
            {
                myCar.StartEngine();
                theirCar.StartEngine();
            }
            else
            {
                Environment.Exit(0);
            }

            myCar.ShowInfo();
            theirCar.ShowInfo();
            IsFasterThan(myCar, theirCar);

            while (myCar.fuelLevel > 0 && myCar.engineOn)
            {
                myCar.Drive();
                theirCar.Drive();
            }

            if (myCar.fuelLevel <= 0)
            {
                Console.WriteLine("Out of fuel! You made it " + myCar.distance + " km");
                Console.WriteLine("Out of fuel! They made it " + theirCar.distance + " km");
            }

            Console.WriteLine("Press B to honk");
            if(Console.ReadLine().ToLower() == "b")
            {
                myCar.Honk();
                Environment.Exit(0);
            }

        }

        static void IsFasterThan(Car yourCar, Car theirCar)
        {
            if(yourCar.maxSpeed > theirCar.maxSpeed)
            {
                Console.WriteLine("Your car is faster than their car");
            }
            else if (yourCar.maxSpeed < theirCar.maxSpeed)
            {
                Console.WriteLine("Their car is faster than your car");
            }
            else
            {
                Console.WriteLine("Both cars have the same speed");
            }
        }
    }

    
}
