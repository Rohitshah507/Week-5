using System;

namespace SchoolApp
{
    public class Teacher
    {
        // Property
        public string Name { get; set; }

        // Virtual method (can be overridden)
        public virtual void Teaching()
        {
            Console.WriteLine("Teacher teaches in English");
        }

        // Sealed method (cannot be overridden)
        public void SalaryInfo()
        {
            Console.WriteLine($"{Name}'s salary information: Confidential");
        }
    }
}
