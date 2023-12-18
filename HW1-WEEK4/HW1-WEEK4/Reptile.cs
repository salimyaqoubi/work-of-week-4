using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_WEEK4
{
    internal class Reptile : Animal
    {
        public Reptile(string name, int age, string species, DietType dietType)
       : base(name, age, species, dietType)
        {
        }

        public override void Move()
        {
            Console.WriteLine("Slithering or crawling");
        }

        public void Swim()
        {
            Console.WriteLine("Swimming");
        }
    }
}
