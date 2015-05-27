using System.Collections.Generic;

namespace Account
{
    public class Account
    {
        public Customer Holder { get; set; }
        public string AccountNo { get; set; }
        public decimal Balance { get; set; }
        public decimal TotalDeposit { get; set; }
        public decimal TotalWithdrawal { get; set; }
        public List<Transaction> TransactionList { get; set; }
        public int TransactionCount { get; set; }
    }
}