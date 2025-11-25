using System;

namespace SchoolApp
{
    public class Printer
    {
        // Overloaded method 1: Print string
        public void Print(string message)
        {
            Console.WriteLine("Message: " + message);
        }

        // Overloaded method 2: Print int
        public void Print(int number)
        {
            Console.WriteLine("Number: " + number);
        }

        // Overloaded method 3: Print string with count
        public void Print(string message, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Message {i + 1}: {message}");
            }
        }
    }
}
