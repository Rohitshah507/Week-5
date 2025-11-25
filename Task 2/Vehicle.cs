using System;

namespace VehicleApp
{
    public class Vehicle
    {
        // Properties
        public string Brand { get; set; }
        public int Speed { get; set; }

        // Methods
        public void Start()
        {
            Console.WriteLine($"{Brand} is starting.");
        }

        public void Stop()
        {
            Console.WriteLine($"{Brand} has stopped.");
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
        }
    }
}
