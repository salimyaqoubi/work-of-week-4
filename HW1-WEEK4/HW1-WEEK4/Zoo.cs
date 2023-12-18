using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace HW1_WEEK4
{
    internal class Zoo
    {
        private Dictionary<string, List<Animal>> enclosures;

        public Zoo()
        {
            enclosures = new Dictionary<string, List<Animal>>();
        }

        public void AddAnimal(Animal animal)
        {
            string category = animal.GetType().Name;
            if (!enclosures.ContainsKey(category))
            {
                enclosures[category] = new List<Animal>();
            }
            enclosures[category].Add(animal);
        }

        public void DisplayAnimals()
        {
            Console.WriteLine("-----------------------------");
            foreach (var category in enclosures.Keys)
            {
                foreach (var animal in enclosures[category])
                {
                    Console.WriteLine($"Animal: {animal.Name}, Age: {animal.Age}, Species: {animal.Species}, Diet: {animal.DietType}");
                }
            }
            Console.WriteLine("-----------------------------");
        }
    }
}
