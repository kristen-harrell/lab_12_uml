using System;
using System.Collections.Generic;
using System.Text;

namespace lab_12_class_uml
{
    class Staff : Person
    {
        private string School { get; set; }
        private double Pay { get; set; }



        public Staff(string Name, string Address) : base(Name, Address)
        {

        }

        public Staff(string Name, string Address, string school, double pay)
            : base(Name, Address)
        {
            this.School = school;
            this.Pay = pay;
        }

        public override void PrintPerson()
        {
            base.PrintPerson();
            Console.WriteLine($"School: {School}");
            Console.WriteLine($"Pay: {Pay:c}");

        }

        public static object AddStaff()
        {
            Console.WriteLine("Enter the Staff member's name: ");
            string addName = Console.ReadLine();
            Console.WriteLine("Enter the address: ");
            string addAddress = Console.ReadLine();
            Console.WriteLine("Enter the school: ");
            string addSchool = Console.ReadLine();
            Console.WriteLine("Enter the pay: ");
            double addPay = double.Parse(Console.ReadLine());

            return new Staff(addName, addAddress, addSchool, addPay);
            //Person.RegisteredPerson(new Staff, );
        }


    }
}
