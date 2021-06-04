using System;
namespace Week9WeeklyAssignment
{
    // drived class : base class
    public class CheckingAccount : BankAccount
    {
        public int ChecksUsed { get; set; }

        public CheckingAccount(int iD, int accountNum, string pass, int bal, int checksUsed) : base(iD, accountNum, pass, bal) { ChecksUsed = checksUsed;  }

        public override string ToString()
        {
            return $"Account=> ID: {ID}, Account Number: {AccountNumber}, Password: {Password}, Balance: {Balance}, Checks Used: {ChecksUsed}";
        }
    }

}
