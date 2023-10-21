namespace Orders
{
    internal class Shop
    {
        Queue<Order> allOrders = new Queue<Order>();
        Queue<Order> processedOrders = new Queue<Order>();
        public void AddOrder(Order order)
        {
            allOrders.Enqueue(order);
        }

        public void OrderProcessing()
        {
            if (allOrders.Count > 0)
            {
                Order order = allOrders.Peek();
                Console.WriteLine($"Order #{order.OrderNumber} in progress...");
                Console.WriteLine($"Customer {order.CustomerName} received the order!");
                processedOrders.Enqueue(order);
                allOrders.Dequeue();
            } else
            {
                Console.WriteLine("Orders is empty");
            }
        }

        public void GetOrdersInfo()
        {
            foreach( Order order in allOrders)
            {
                Console.WriteLine(order);
                Console.WriteLine();
            }
        }

        private double GetTotalAmount()
        {
            double total = 0;
            foreach( Order order in processedOrders)
            {
                total += order.TotalAmount;
            }
            return total;
        }
        
        public void GetStatistics()
        {
            Console.WriteLine($"Count of processed orders: {processedOrders.Count()}");
            Console.WriteLine($"Total summ of processed orders: {GetTotalAmount()}");
            Console.WriteLine();
        }
    }
}
