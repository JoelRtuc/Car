namespace Car
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.brand = "Jeep";
            myCar.color = "Red";
            myCar.maxSpeed = 2020;
            myCar.horsePower = 300;
            myCar.engineOn = false;


            Console.WriteLine($"Brand: {myCar.brand} Color: {myCar.color} Year: {myCar.maxSpeed} Engine: {myCar.engineOn}");
        }
    }

    
}
