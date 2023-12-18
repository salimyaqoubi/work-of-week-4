using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week4_day13
{
    internal class Employee : People
    {
        string Role;
        int WorkingHours;
        double Wage;


        public Employee(int Id, string Name, int Age, int SSN, string Address, string Role, int WorkingHours, double Wage):base(Id, Name, Age, SSN, Address)
        {
            this.Role = Role;
            this.WorkingHours = WorkingHours;
            this.Wage = Wage;
        }

        //public void PrintInfo()
        //{
        //    Console.WriteLine($"hello mr {this.Name} your position is {this.Role}" );
        //}

        public override string ToString()
        {
            return base.ToString() + $"your position is {this.Role} and your phone number is {this.SSN}";
            //return base.ToString();
        }

        //public override void CalculateSalary() 
        //{
        //    base.CalculateSalary() ;
        //    Console.WriteLine($"your total salary is calculated ");
        //}
    }
}
