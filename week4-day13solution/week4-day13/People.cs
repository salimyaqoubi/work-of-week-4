using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week4_day13;

namespace week4_day13
{
    interface IMove
    {
        void Move();
        void Eat();
        void Sleep();
    }

    internal class People : IMove
    {
        #region Members
        public int Id;
        public string Name;
        public int Age;
        public int SSN;
        public string Address;
        #endregion

        public People(int Id, string Name, int Age, int SSN, string Address)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
            this.SSN = SSN;
            this.Address = Address;
        }
        public override string ToString()
        {
            return $"Hello Mr {this.Name} Your age is {this.Age}";
        }
        //public virtual void CalculateSalary()
        //{
        //    Console.WriteLine("your salary is calculated according to : ");
        //}

        public void Move()
        {
            Console.WriteLine("Moving");
        }
        public void Eat()
        {
            Console.WriteLine("Eating");
        }
        public void Sleep()
        {
            Console.WriteLine("Sleeping");
        }

    }  
}

