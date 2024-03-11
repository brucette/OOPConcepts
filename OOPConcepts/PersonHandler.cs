using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace OOPConcepts
{   
    internal class PersonHandler
    {
        public void SetAge(Person pers, int age) 
        { 
            pers.Age = age;
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight) 
        {
            return new Person(age, fname, lname, height, weight);
        }

        public void Grow(Person pers) 
        {
            if (pers.Age > 18)
                throw new ArgumentException("Cannot grow at this age..\n");

            pers.Height += 0.01;
        }

        public void LoseWeight(Person pers, int kilos)
        {
            if (pers.Weight - kilos < 10)
                throw new ArgumentException("That's impossible, they would cease to exist!\n");

            pers.Weight -= kilos;
        }
    }
}
