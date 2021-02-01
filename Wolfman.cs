using System;
using System.Collections.Generic;
using System.Text;

namespace Övning3
{
    class Wolfman : Wolf, IPerson
    {
        public Wolfman (int age, string name, int weight) : base(age, name, weight)
        {
          
        }
      public void Talk()
        {
            Console.WriteLine("snickesnack");
        }
    }
}
