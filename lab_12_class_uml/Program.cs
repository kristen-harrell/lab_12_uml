using System;
using System.Collections.Generic;

namespace lab_12_class_uml
{
    class Program
    {
        static void Main(string[] args)
        {

            Staff Pam = new Staff("Pam", "1234 Pine Ave", "Scranton Art School North", 1000.00);
            Staff Phyllis = new Staff("Phyllis", "123 Lilly Street", "Scranton Art School South", 850.00);
            Student Angela = new Student("Angela", "123 Appletree Lane", "Calligraphy", 3, 600.00);
            Student Oscar = new Student("Oscar", "123 Palm Tree Lane", "Sculpting", 2, 800.00);
            Student Toby = new Student("Toby", "123 Willow Tree Ave", "Oil Painting", 1, 600.00);




            //this works because each staff or student is also a Person.  This will allow me to print all the humans
            //if I only want students or staff, I write the same thing, but replace the word Person with Staff or student (see below)
            List<Person> SchoolList = new List<Person>
            {
                Pam, Phyllis, Angela, Oscar, Toby
            };

            //List<Student> StudentList = new List<Student>
            //{
            //    Angela, Oscar, Toby
            //};

            Console.WriteLine("heres the whole school:");
            foreach (Person person in SchoolList)
            {
                person.PrintPerson();
                Console.WriteLine("========================");
            }


            ////in order to make this, I had to make a list of students, and then a print comand on the student class
            //Console.WriteLine("here's just the students:");
            //foreach (Student student in StudentList)
            //{
            //    student.PrintStudent();
            //    Console.WriteLine("========================");
            //}

            Console.WriteLine("Enter 1 to add a student or 2 to add a staff member:  ");
            int userChoice = int.Parse(Console.ReadLine());
            if (userChoice == 1)
            {
                Student.AddStudent();
            }
            else if (userChoice == 2)
            {
                 Staff.AddStaff();
            }
            else
            {
                Console.WriteLine("that was an invalid selection.  Goodbye");
            }

            //Console.WriteLine("heres the whole school:");
            //foreach (Person person in SchoolList)
            //{
            //    person.PrintPerson();
            //    Console.WriteLine("========================");
            //}

        }

        //public static List<string> RegisterPeople(string newPerson)
        //{
        //    List<string> registeredPeople = new List<string>();
        //    registeredPeople.Add(newPerson);
        //    return registeredPeople;
        //}
    }
}
