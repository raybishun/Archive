using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02d_Events
{
    public enum FailReason
    {
        AccountFrozen,
        DisallowedOverdrawn,
        AccountDBOffline,
        RestrictionByAccountHolder
    }

    public class TransactionEventArgs : EventArgs
    {
        public string Message { get; set; }
        public FailReason WhyItFailed { get; set; }

        public TransactionEventArgs(string message, FailReason reason)
        {
            Message = message;
            WhyItFailed = reason;
        }
    }
}
