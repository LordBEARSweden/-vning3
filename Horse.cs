using System;
using System.Collections.Generic;
using System.Text;

namespace Övning3
{
    class Horse : Animal
    {
        public string Breed { get; set;}
        public Horse(int age, string name, int weight, string breed) :base(age, name, weight)
        {
            //AnimalAge = 2;
            //AnimalName = "Månella";
            //AnimalWeight = 200;
            Breed = breed;
        }

        public override string DoSound()
        {
            return "Gnääääääg";
        }

        public override string Stats()
        {
            return base.Stats() + $", {Breed}.";
        }
    }


    
}
 