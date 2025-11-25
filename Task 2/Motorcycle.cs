using System;

namespace VehicleApp
{
    public class Motorcycle : Vehicle
    {
        // Unique field
        public bool HasCarrier { get; set; }

        // Constructor
        public Motorcycle(string brand, int speed, bool hasCarrier)
        {
            Brand = brand;
            Speed = speed;
            HasCarrier = hasCarrier;
        }

        // Override DisplayInfo
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Has Carrier: {HasCarrier}");
        }
    }
}
