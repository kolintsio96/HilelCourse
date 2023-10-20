namespace Shop
{
    internal class Cart
    {
        List<Product> cart = new List<Product>();
        public void AddToCart(Product product)
        {
            cart.Add(product);
        }
        public void RemoveFromCart(int productId)
        {
            if (cart.Count > 0)
            {
                cart.RemoveAll(c => c.Id == productId);
            } else
            {
                Console.WriteLine("Cart is empty");
            }
        }
        public double GetTotalPrice()
        {
            double total = 0;
            foreach (Product product in cart)
            {
                total += product.Price;
            }
            return total;
        }
    }
}
