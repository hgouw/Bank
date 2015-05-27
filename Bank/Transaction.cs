using System;

namespace Account
{
    public class Transaction
    {
        public DateTime TransactionDate { get; set; }
        public string TransactionDescription { get; set; }
        public decimal TransactionAmount { get; set; }
    }
}