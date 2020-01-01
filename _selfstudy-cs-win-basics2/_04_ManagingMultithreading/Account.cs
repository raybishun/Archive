using System;
using System.Threading;

namespace _04_ManagingMultithreading
{
    class Account
    {
        private object thisLock = new object();
        int balance = 0;

        Random r = new Random();

        public Account(int initial)
        {
            balance = initial;
        }

        public int Withdraw(int amount)
        {
            if (balance < 0)
            {
                throw new Exception("Negative Blance");
            }

            lock(thisLock)
            {
                if (balance >= amount)
                {
                    Console.WriteLine($"Activity on thread#{Thread.CurrentThread.ManagedThreadId}");
                    Console.WriteLine($"Balance before Withdrawal: {balance}");
                    Console.WriteLine($"Amount ot Withdraw     :-{amount}");
                    balance = balance - amount;
                    Console.WriteLine($"Balance after Withdrawal: {balance}");
                    Console.WriteLine("--");
                    return amount;
                }
                else
                {
                    return 0; //transaction rejected
                }
            }
        }

        public void DoTransactions()
        {
            for (int i = 0; i < 100; i++)
            {
                Withdraw(r.Next(1, 100));
            }
        }
    }
}
