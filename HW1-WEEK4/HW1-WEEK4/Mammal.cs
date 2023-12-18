using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_WEEK4
{
    internal class Mammal : Animal
    {
        public Mammal(string name, int age, string species, DietType dietType)
        : base(name, age, species, dietType)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Roaring sound");
        }
    }
}
