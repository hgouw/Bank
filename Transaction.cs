using System;

namespace Bank
{
    class Transaction
    {
        public DateTime TransactionDate { get; set; }
        public string TransactionDescription { get; set; }
        public double TransactionAmount { get; set; }

        public static Transaction Create(string transactionDate = "1/1/2014", string transactionDescription = "", double transactionAmount = 0)
        {
            return new Transaction { TransactionDate = Convert.ToDateTime(transactionDate), TransactionDescription = transactionDescription, TransactionAmount = transactionAmount };
        }
    }
}
