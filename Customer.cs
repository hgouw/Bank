namespace Bank
{
    class Customer
    {
        public string CustomerName { get; set; }
        public string UserId { get; set; }
        public string Pin { get; set; }

        public static Customer Create(string customerName, string userId, string pin)
        {
            return new Customer { CustomerName = customerName, UserId = userId, Pin = pin };
        }
    }
}
