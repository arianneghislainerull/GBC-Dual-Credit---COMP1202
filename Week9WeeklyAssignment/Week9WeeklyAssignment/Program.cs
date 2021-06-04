using System;

namespace Week9WeeklyAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Weekly Assignment");

            // Driver Class

            BankAccount account1 = new BankAccount(33,33,"BankAccount1",33);
            BankAccount checkingAccount1 = new CheckingAccount(111,11,"CheckingAccount1",23,234);
            BankAccount savingsAccount1 = new SavingsAccount(222,22,"SavingsAccount1",23,22);

            Console.WriteLine(account1);
            Console.WriteLine(checkingAccount1);
            Console.WriteLine(savingsAccount1);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
