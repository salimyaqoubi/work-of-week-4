using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace week4_day15
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            Print(1);
            Print("Hello there");

            #region objectuse

            Print(new { firstname = "akram", lastname = "Juma" });
            Print(new Person { Fname = "Akram", Lname = "juma" });
            #endregion

            #region Delegate
            
                        Employee[] emps = new Employee[]
                        {
                            new Employee { Id = 1, Name = "Akram", gender = 'm', TotalSales = 70000m },
                            new Employee { Id = 2, Name = "Salim", gender = 'm', TotalSales = 15000m },
                            new Employee { Id = 3, Name = "Juma", gender = 'm', TotalSales = 30000m },
                            new Employee { Id = 4, Name = "Amal", gender = 'f', TotalSales = 27000m },
                            new Employee { Id = 5, Name = "Motaz", gender = 'm', TotalSales = 82000m },
                            new Employee { Id = 6, Name = "Nader", gender = 'm', TotalSales = 60000m },
                            new Employee { Id = 7, Name = "Fatma", gender = 'f', TotalSales = 50000m },
                            new Employee { Id = 8, Name = "Ali", gender = 'm', TotalSales = 10000m },
                        };

                        Report report = new Report();

                        report.TotalSalesmorethan60k(emps);
                        report.TotalSalesbetween30kto59999k(emps);
                        report.TotalSaleslessthan30k(emps);


                        //Sugar Syntax
                        report.ProcessEmployee(emps, "total sales morethan 60k", (emp) => emp.TotalSales >= 60000m);
                        report.ProcessEmployee(emps, "total sales between 30k to 60k", (emp) => emp.TotalSales >= 30000m && emp.TotalSales <= 60000m);
                        report.ProcessEmployee(emps, "total sales lessthan 30k", (emp) => emp.TotalSales < 30000m);



                       report.ProcessEmployee(emps, "total sales morethan 60k", greater60);
                       report.ProcessEmployee(emps, "total sales between 30k to 60k", inbetween3060);
                       report.ProcessEmployee(emps, "total sales lessthan 30k", lessthan30);

                       bool greater60(Employee emp) => emp.TotalSales >= 60000m;
                       bool inbetween3060(Employee emp) => emp.TotalSales >= 30000m && emp.TotalSales <= 60000m;
                       bool lessthan30(Employee emp) => emp.TotalSales < 30000m;
                       
            #endregion


            Arr<int> number = new arr<int>();
            number.add(1);
            number.add(2);
            number.add(3);
            number.add(4);
            number.Removeat(0);
            Console.WriteLine(number.Count);
            Console.WriteLine(number.isEmpty);
            number.display();

            Arr<Person> people = new arr<Person>();
            people.add(new Person() { Fname = "salim", Lname = "juma" });
            people.add(new Person() { Fname = "akram", Lname = "juma" });
            people.display();
            */
        }
            /*
        public static void Print<T>(T obj)
        {
            Console.WriteLine($"Datatype : {typeof(T)}");
            Console.WriteLine(obj);
        }
        */
    }
}
