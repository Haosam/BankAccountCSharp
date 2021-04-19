using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class GiftCardAccount : BankAccount
    {
        private decimal _monthlyDeposit = 0m;

        public GiftCardAccount(string name, decimal initialBalance, int pin, decimal monthlyDeposit = 0) : base(name, initialBalance, pin)
            => _monthlyDeposit = monthlyDeposit;

        public override void PerformMonthEndTransactions()
        {
            if (_monthlyDeposit != 0)
            {
                MakeDeposit(_monthlyDeposit, DateTime.Now, "Add monthly deposit");
            }
        }
    }
}
