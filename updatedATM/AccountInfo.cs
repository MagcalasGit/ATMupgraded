using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atmsystem
{
    public static class AccountManager
    {
        public static string AccountNumber { get; private set; }
        public static string PIN { get; set; }
        public static decimal SavingsBalance { get; set; }
        public static decimal ChequeBalance { get; set; }

        public static void SetAccountNumber(string accountNumber)
        {
            AccountNumber = accountNumber;
        }
    }
}
