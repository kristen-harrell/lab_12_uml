using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace lab_12_class_uml
{
    class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Person> registeredPerson;

        public List<Person> RegisteredPerson
        {
            get { return registeredPerson; }
            set { registeredPerson = value; }
        }

        //Constructors -- special methods that helps build (instantiate) an object
        //public Person() { } //<-- Default constructor


        public Person(string Name, string Address)
        {
            this.Name = Name;
            this.Address = Address;
        }

        public Person()
        {
            RegisteredPerson = new List<Person>();

        }

        public virtual void PrintPerson()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Address: {Address}");

        }
    }


}

