namespace ConsoleApp1
{
    enum Months
    {
        jan,
        feb,
        mar,
        april,
        may,
        june,
        july,
        aug,
        sep,
        oct,
        nov,
        dec,
    }


    internal class Program
    {
        [Flags]
        enum Permission
        {
            None = 0,
            Read = 1,
            Write = 2,
            Delete = 3,
            Execute = 8,
            Level1 = Read | Write,
            Admin = Read | Write | Delete,
            superAdmin = Read | Write | Delete | Execute,
        }
        static void Main(string[] args)
        {
            Months months = Months.june;
            Console.WriteLine((int)months);

            Permission myPermission = Permission.Read | Permission.Write;
            Console.WriteLine(myPermission);

            if (User.HasFlag(Permission.Level1))
            {
                Console.WriteLine($"you have only read write your CARDENTIALS IS : " + 
                    $"{Permission.Level1.ToString()}");

                string month = "feb";
                
            }
        }
    }
}