using System;

namespace VehicleApp
{
    public class Car : Vehicle
    {
        // Unique field
        public int Seats { get; set; }

        // Constructor
        public Car(string brand, int speed, int seats)
        {
            Brand = brand;
            Speed = speed;
            Seats = seats;
        }

        // Override DisplayInfo
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Seats: {Seats}");
        }
    }
}
