namespace Shop
{
    internal class Shop
    {
        List<Product> products = new List<Product>();
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void RemoveProduct(int productId)
        {
            if (products.Count > 0)
            {
                products.RemoveAll(product => product.Id == productId);
            }
            else
            {
                Console.WriteLine("Shop is empty");
            }
        }

        public Product GetProductById(int productId)
        {
            Product? product = products.Find(i => i.Id == productId);
            if(product == null)
            {
                throw new Exception($"Product with id {productId} not found");
            }
            else
            {
                return product;
            }
        }
        
        public List<Product> GetAllProducts()
        {
            return products;
        }
    }
}
