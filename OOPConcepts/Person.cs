using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{
    internal class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        public int Age 
        {
            get { return age; }
            set 
            {
                if (value <= 0)
                    throw new ArgumentException("Age must be more than 0.");

                age = value;    
            }
        }

        public string FName 
        { 
            get { return fName; } 
            set 
            {
                if (String.IsNullOrWhiteSpace(value) || value.Length < 2 || value.Length > 10)
                    throw new ArgumentException("First name is required and should be between 2 and 10 characters long.\n");

                fName = value;
            }
        }

        public string LName
        {
            get { return lName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value) || value.Length < 3 || value.Length > 15)
                    throw new ArgumentException("Last name is required and should be between 3 and 15 characters long.\n");

                lName = value;
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                height = value;
            }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
            }
        }

        public Person(int age, string fname, string lname, double height, double weight)
        {
            Age = age;
            FName = fname;
            LName = lname;
            Height = height;
            Weight = weight;
        }
    }
}
