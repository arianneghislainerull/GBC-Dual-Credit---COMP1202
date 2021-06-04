using System;
namespace Week9WeeklyAssignment
{
    // drived class : base class
    public class SavingsAccount : BankAccount
    {
        public int Interest { get; set; }

        public SavingsAccount(int iD, int accountNum, string pass, int bal, int interest) : base(iD, accountNum, pass, bal) { Interest = interest; }

        public override string ToString()
        {
            return $"Account=> ID: {ID}, Account Number: {AccountNumber}, Password: {Password}, Balance: {Balance}, Interest: {Interest}";
        }

    }
}
