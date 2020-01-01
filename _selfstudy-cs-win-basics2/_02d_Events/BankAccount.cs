using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02d_Events
{
    public delegate void TransactionFailed(object sender, TransactionEventArgs e);

    public class BankAccount : ILogger, ICustomer
    {
        public event TransactionFailed OnTransactionFailed;

        public static readonly decimal MinimumRequiredOpeningDeposit = 50M;


        //public BankAccount(MoneyStruct defaultMoneyType): this("Unknown", 50M, defaultMoneyType)
        //{

        //}


    }
}
