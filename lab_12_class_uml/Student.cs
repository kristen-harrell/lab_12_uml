using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Text;

namespace lab_12_class_uml
{
    class Student : Person
    {
        private string Program { get; set; }
        private int Year { get; set; }
        private double Fee { get; set; }


        public Student(string Name, string Address) :base(Name, Address)
        {

        }

        public Student(string Name, string Address, string program, int year, double fee)
            :base(Name, Address)
        {
            this.Program = program;
            this.Year = year;
            this.Fee = fee;
        }

        public override void PrintPerson()
        {
            base.PrintPerson();
            Console.WriteLine($"Program: {Program}");
            Console.WriteLine($"Year: { Year}");
            Console.WriteLine($"Fee: {Fee:c}");
              
        }
        public void PrintStudent()
        {
            base.PrintPerson();
            Console.WriteLine($"Program: {Program}");
            Console.WriteLine($"Year: { Year}");
            Console.WriteLine($"Fee: {Fee:c}");
        }

        public static object AddStudent()
        {
            Console.WriteLine("Enter the Student's name: ");
            string addName = Console.ReadLine();
            Console.WriteLine("Enter the address: ");
            string addAddress = Console.ReadLine();
            Console.WriteLine("Enter the program: ");
            string addProgram = Console.ReadLine();
            Console.WriteLine("Enter the year: ");
            int addYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the fee: ");
            double addFee = double.Parse(Console.ReadLine());

            return new Student(addName, addAddress, addProgram, addYear, addFee);
        }

    }
}
