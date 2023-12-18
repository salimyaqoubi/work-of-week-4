using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace week4_day15
{
    internal class Report
    {

        public void TotalSalesmorethan60k(Employee[] emp)
        {
            Console.WriteLine("report for employee total sales morethan 60k");
            Console.WriteLine("-----------------------------------------------");
            foreach (Employee e in emp)
            {
                if (e.TotalSales >= 60000m)
                {
                    Console.WriteLine($"{e.Id} | {e.Name} | {e.gender} | {e.TotalSales}");
                }
            }
        Console.WriteLine("\n\n");
        }

        public void TotalSalesbetween30kto59999k(Employee[] emp)
        {
            Console.WriteLine("report for employesstotal sales between 30k to 60k");
            Console.WriteLine("----------------------------------------------------------");
            foreach (Employee e in emp)
            {
                if( 30000m <= e.TotalSales && e.TotalSales <= 59999m)
                {
                    Console.WriteLine($"{e.Id} | {e.Name} | {e.gender} | {e.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");
        }


        public void TotalSaleslessthan30k(Employee[] emp)
        {
            Console.WriteLine("report for employess total sales lessthan 30k ");
            Console.WriteLine("----------------------------------------------------------");
            foreach (Employee e in emp)
            {
                if (e.TotalSales < 30000m)
                {
                    Console.WriteLine($"{e.Id} | {e.Name} | {e.gender} | {e.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");
        }

        public delegate bool SalesCondition(Employee e);
        public void ProcessEmployee(Employee[] emp, string Title , SalesCondition cond)
        {
            Console.WriteLine(Title);
            Console.WriteLine("-----------------------------------------");
            foreach (Employee e in emp)
            {
                if (cond(e))
                {
                    Console.WriteLine($"{e.Id} | {e.Name} | {e.gender} | {e.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}
