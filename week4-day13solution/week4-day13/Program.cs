namespace week4_day13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // abstract keyword
            //Region p1 = new Region(1, "salim", 22, 936645, "oman");
            Employee emp = new Employee(1,"salim",22,936645,"oman","full stack developer", 8, 20.3);
            //emp.PrintInfo();
            Console.WriteLine(emp);
            Console.WriteLine(emp.ToString());
            //emp.CalculateSalary();
            .Move();
        }
    }
}