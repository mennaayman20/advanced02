namespace advanced02
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; } // "Electronics", "Clothing", "Food", "Books"
        public double Price { get; set; }
        public int Stock { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. Product Catalog
            List<Product> catalog = new()
        {
            new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10 },
            new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 25 },
            new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 30, Stock = 100 },
            new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 60, Stock = 50 },
            new Product { Id = 5, Name = "Chocolate", Category = "Food", Price = 5, Stock = 200 },
            new Product { Id = 6, Name = "Coffee Beans", Category = "Food", Price = 15, Stock = 80 },
            new Product { Id = 7, Name = "C# Book", Category = "Books", Price = 45, Stock = 30 },
            new Product { Id = 8, Name = "Novel", Category = "Books", Price = 20, Stock = 60 },
            new Product { Id = 9, Name = "Headphones", Category = "Electronics", Price = 150, Stock = 40 },
            new Product { Id = 10, Name = "Jacket", Category = "Clothing", Price = 120, Stock = 15 }
        };

            // call delegate



            Console.WriteLine("--- Electronics ---");
            var electronics = SearchProducts.SearchProduct(catalog, p => p.Category == "Electronics");

            foreach (var p in electronics)
            {
                Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");
            }


            Console.WriteLine("\n--- Under $50 ---");
            var under50 = SearchProducts.SearchProduct(catalog, p => p.Price < 50);
            foreach (var p in under50)
                Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");

            Console.WriteLine("\n--- In Stock ---");
            var inStock = SearchProducts.SearchProduct(catalog, p => p.Stock > 0);
            foreach (var p in inStock)
            {
                Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");
            }

            Console.WriteLine("\n--- Clothing Under $100 ---");
            var clothingUnder100 = SearchProducts.SearchProduct(catalog, p => p.Category == "Clothing" && p.Price < 100);
            foreach (var p in clothingUnder100)
            {
                Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");
            }

































        }
    }
}
