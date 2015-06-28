using System.Collections.Generic;

namespace Bank
{
    class Account
    {
        private List<Transaction> _transactions;

        public Account()
        {
            _transactions = new List<Transaction>();
        }

        public Customer Holder { get; set; }
        public string AccountNo { get; set; }
        public double Balance { get; set; }
        public double TotalDeposit { get; set; }
        public double TotalWithdrawal { get; set; }
        public List<Transaction> TransactionList { get { return _transactions; } }
        public int TransactionCount { get { return TransactionList.Count; } }

        public static Account Create(Customer holder, string accountNo, double balance, double deposit, double withdrawal)
        {
            return new Account { Holder = holder, AccountNo = accountNo, Balance = balance, TotalDeposit = 0, TotalWithdrawal = 0};

        }
    }
}
