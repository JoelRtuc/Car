namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.brand = "Jeep";
            myCar.color = "Red";
            myCar.year = 2020;
            myCar.horsePower = 300;
            myCar.gears = 8;
            myCar.engineOn = false;


            Console.WriteLine($"Brand: {myCar.brand} Color: {myCar.color} Year: {myCar.year} Engine: {myCar.engineOn}");
        }
    }

    
}
