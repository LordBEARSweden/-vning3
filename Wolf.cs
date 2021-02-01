using System;
using System.Collections.Generic;
using System.Text;

namespace Övning3
{
    class Wolf : Animal
    {
        public int NumberInPack { get; set; }

        public Wolf(int age, string name, int weight) :base(age, name, weight)
        {
            NumberInPack = NumberInPack;
        }
        public override string DoSound()
        {
            return "howl!";
        }
        
    }
}
