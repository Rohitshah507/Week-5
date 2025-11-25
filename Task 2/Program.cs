using System;

namespace VehicleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Car object
            Car myCar = new Car("Toyota", 180, 5);
            myCar.Start();
            myCar.DisplayInfo();
            myCar.Stop();

            Console.WriteLine();

            // Create Motorcycle object
            Motorcycle myBike = new Motorcycle("Honda", 120, true);
            myBike.Start();
            myBike.DisplayInfo();
            myBike.Stop();
        }
    }
}
