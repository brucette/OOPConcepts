using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    internal class PersonHandler
    {
        // PUNKT 3.1.2
        public void SetAge(Person pers, int age) 
        { 
            pers.Age = age;
        }

        // PUNKT 3.1.3
        public Person CreatePerson(int age, string fname, string lname, double height, double weight) 
        {
            return new Person(age, fname, lname, height, weight);
        }

        // PUNKT 3.1.4
        public void Grow(Person pers) 
        {
            if (pers.Age > 18)
                throw new ArgumentException("Cannot grow at this age..");
            pers.Height += 0.01;

        }

        public void ChangeName(string name)
        {
            Console.WriteLine(
                "Which name would you like to change." +
                "\n1. First name" +
                "\n2. Last name" +
                "\nYour selection:");

        }
    }
}
