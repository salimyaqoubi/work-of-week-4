using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;


namespace HW1_WEEK4
{
    enum DietType
    {
        CARNIVORE,
        HERBIVORE,
        OMNIVORE
    }
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }
        public DietType DietType { get; set; }

        public Animal(string name, int age, string species, DietType dietType)
        {
            Name = name;
            Age = age;
            Species = species;
            DietType = dietType;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Generic animal sound");
        }

        public virtual void Move()
        {
            Console.WriteLine("Generic animal movement");
        }
    }

}
