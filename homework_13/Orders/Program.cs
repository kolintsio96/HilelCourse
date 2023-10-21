namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            shop.AddOrder(new Order(124, "Volodymyr", 250.25));
            shop.AddOrder(new Order(125, "Ann", 750));
            shop.AddOrder(new Order(126, "Oleg", 96.5));
            shop.GetOrdersInfo();
            shop.GetStatistics();

            shop.OrderProcessing();
            shop.GetStatistics();

            shop.OrderProcessing();
            shop.GetStatistics();

            shop.OrderProcessing();
            shop.GetStatistics();

            shop.OrderProcessing();
            shop.GetStatistics();
        }
    }
}