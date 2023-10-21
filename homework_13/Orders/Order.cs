namespace Orders
{
    internal class Order
    {
        public int OrderNumber { get; set; }
        public string CustomerName { get; set; }
        public double TotalAmount { get; set; }

        public Order(int orderNumber, string customerName, double totalAmount)
        {
            OrderNumber = orderNumber;
            CustomerName = customerName;
            TotalAmount = totalAmount;
        }

        public override string ToString()
        {
            return $"Order #{OrderNumber}\nCustomer: {CustomerName}\nTotal amount: {TotalAmount}";
        }
    }
}
