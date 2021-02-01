using System;
using System.Collections.Generic;
using System.Text;

namespace Övning3
{
   abstract class Animal
    {

        public Animal(int age, string name, int weight)
        {
            Age = age;
            Name = name;
            Weight = weight;
        }

        public int Age { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }

        public abstract string DoSound();
        
        public virtual string Stats()
        {
            return $"{Age}, {Name}, {Weight}";
        }
       
    }
    
}
