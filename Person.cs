using System;
using System.Collections.Generic;
using System.Text;

namespace Övning3
{
    public class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        public Person(int age, string fname, string lname, double height, double weight)
        {
            Age = age;
            FName = fname;
            LName = lname;
            Height = height;
            Weight = weight;
        }

        public Person()
        {

        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("age can not be zero or typed with letters");
                }
                age = value;
            }
        }

        public string FName
        {
            get { return fName; }
            set
            {
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException("First name is invalid. Either to short or to long.");
                }

                fName = value;
            }
        }
        public string LName
        {
            get { return lName; }
            set
            {
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Last name is invalid. Either to short or to long.");
                }
                lName = value;
            }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
       
    }
}
