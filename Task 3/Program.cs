using System;

namespace SchoolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----- Printer Demonstration -----
            Printer printer = new Printer();

            printer.Print("Hello World");
            printer.Print(12345);
            printer.Print("Repeated Message", 3);

            Console.WriteLine("\n----- Teacher Demonstration -----\n");

            // ----- Teacher Demonstration -----
            NepaliTeacher nepaliTeacher = new NepaliTeacher { Name = "Mr. Sharma" };
            EnglishTeacher englishTeacher = new EnglishTeacher { Name = "Ms. Smith" };

            // Nepali Teacher
            nepaliTeacher.Teaching();
            nepaliTeacher.SalaryInfo();

            Console.WriteLine();

            // English Teacher
            englishTeacher.Teaching(); // Uses base class method
            englishTeacher.SalaryInfo();
        }
    }
}
