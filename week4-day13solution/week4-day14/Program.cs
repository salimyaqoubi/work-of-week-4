using System;

namespace week4_day14
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

    [Flags]
    enum Permission
    {
        None = 0,
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8,
        Level1 = Read | Write,
        Admin = Read | Write | Delete,
        SuperAdmin = Read | Write | Delete | Execute,
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Months months = Months.june;
            Console.WriteLine((int)months);

            Permission myPermission = Permission.Read | Permission.Write;
            Console.WriteLine(myPermission);

            if (myPermission.HasFlag(Permission.Level1))
            {
                Console.WriteLine($"You have only read and write permissions. Your credentials are: {Permission.Level1.ToString()}");

                string month = "feb";
                if(Enum.TryParse(month, true, out Months mnth))

                {
                    Console.WriteLine(mnth);
                }

                if (Enum.IsDefined(typeof(Months), month))
                {
                    Console.WriteLine(Enum.Parse(typeof(Months), month));
                }

                foreach (Months mnths in Enum.GetValues(typeof(Months)))
                {
                    Console.WriteLine(mnth + ":" + (int)mnth);
                }
            }
        }
    }
}
