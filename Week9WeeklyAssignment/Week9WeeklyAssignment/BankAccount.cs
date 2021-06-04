using System;
namespace Week9WeeklyAssignment
{
    // superclass

    public class BankAccount
    {

        public int ID { get; set; }
        public int AccountNumber { get; set; }
        public string Password { get; set; }
        public int Balance { get; set; }

        public BankAccount(int iD, int accountNum, string pass, int bal)
        {
            ID = iD;
            AccountNumber = accountNum;
            Password = pass;
            Balance = bal;
        }

        public override string ToString()
        {
            return $"Account=> ID: {ID}, Account Number: {AccountNumber}, Password: {Password}, Balance: {Balance}";
        }
    }
}
