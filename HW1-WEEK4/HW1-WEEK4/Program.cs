namespace HW1_WEEK4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main()
            {
                Zoo zoo = new Zoo();

                while (true)
                {
                    Console.WriteLine("Welcome to the Minimalist Zoo Animal Management System!");
                    Console.WriteLine("1. Add Animals to the Zoo");
                    Console.WriteLine("2. Display Zoo Animals");
                    Console.WriteLine("3. Observe Animal Actions");
                    Console.WriteLine("4. Exit");

                    int choice;
                    if (!int.TryParse(Console.ReadLine(), out choice))
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                        continue;
                    }

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter Animal Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Enter Animal Age: ");
                            int age;
                            if (!int.TryParse(Console.ReadLine(), out age))
                            {
                                Console.WriteLine("Invalid age. Please enter a number.");
                                continue;
                            }
                            Console.Write("Enter Animal Species: ");
                            string species = Console.ReadLine();
                            Console.WriteLine("Select Animal Diet Type (1. Carnivore, 2. Herbivore, 3. Omnivore): ");
                            if (!Enum.TryParse(Console.ReadLine(), out DietType dietType) || !Enum.IsDefined(typeof(DietType), dietType))
                            {
                                Console.WriteLine("Invalid diet type. Please enter a valid option.");
                                continue;
                            }

                            Animal animal;
                            switch (dietType)
                            {
                                case DietType.CARNIVORE:
                                    animal = new Mammal(name, age, species, dietType);
                                    break;
                                case DietType.HERBIVORE:
                                    animal = new Bird(name, age, species, dietType);
                                    break;
                                case DietType.OMNIVORE:
                                    animal = new Reptile(name, age, species, dietType);
                                    break;
                                default:
                                    Console.WriteLine("Invalid diet type. Please enter a valid option.");
                                    continue;
                            }

                            zoo.AddAnimal(animal);
                            Console.WriteLine("Animal Added Successfully!");
                            break;

                        case 2:
                            zoo.DisplayAnimals();
                            break;

                        case 3:
                            Console.WriteLine("- Lion makes a");
                            zoo.DisplayAnimalsOfType<Mammal>(m => m.MakeSound());
                            Console.WriteLine("- Eagle");
                            zoo.DisplayAnimalsOfType<Bird>(b => b.Fly());
                            break;

                        case 4:
                            Console.WriteLine("Thank you for using the Minimalist Zoo Animal Management System!");
                            return;

                        default:
                            Console.WriteLine("Invalid choice. Please enter a valid option.");
                            break;
                    }
                }
            }
        
        }
    }
}