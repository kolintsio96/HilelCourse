namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop vegetableShop = new Shop();
            vegetableShop.AddProduct(new Product(1, "potato", 14));
            vegetableShop.AddProduct(new Product(2, "onion", 28));
            vegetableShop.AddProduct(new Product(3, "carrot", 18));
            vegetableShop.AddProduct(new Product(4, "tomato", 45));
            vegetableShop.RemoveProduct(3);


            Shop fruitShop = new Shop();
            fruitShop.AddProduct(new Product(1, "apple", 20));
            fruitShop.AddProduct(new Product(2, "banana", 35));
            fruitShop.AddProduct(new Product(3, "pineapple", 120));
            fruitShop.AddProduct(new Product(4, "lemon", 50));

            Cart user1 = new Cart();
            user1.AddToCart(vegetableShop.GetProductById(1));
            user1.AddToCart(vegetableShop.GetProductById(4));
            foreach (Product product in fruitShop.GetAllProducts())
            {
                user1.AddToCart(product);
            }
            Console.WriteLine($"User1 total price: {user1.GetTotalPrice()}");
            user1.RemoveFromCart(1);
            Console.WriteLine($"User1 total price after remove: {user1.GetTotalPrice()}");

            Cart user2 = new Cart();
            user2.AddToCart(fruitShop.GetProductById(3));
            user2.AddToCart(fruitShop.GetProductById(2));
            user2.AddToCart(vegetableShop.GetProductById(2));
            user2.AddToCart(vegetableShop.GetProductById(1));
            Console.WriteLine($"User2 total price: {user2.GetTotalPrice()}");
        }
    }
}