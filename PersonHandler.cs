using System;
using System.Collections.Generic;
using System.Text;

namespace Övning3
{
    class PersonHandler
    {
        public Person CreatePerson( int age, string fname, string lname, double height, double weight)
        {
            //Person pers1 = new Person()
            //{
            //    Age = age,
            //    FName = fname,
            //    LName = lname,
            //    Height = height,
            //    Weight = weight
            //};
            //return pers1;

            return new Person(age, fname, lname, height, weight);
        }
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        internal int GetAge(Person person)
        {
            return person.Age;
        }
        
    }
}