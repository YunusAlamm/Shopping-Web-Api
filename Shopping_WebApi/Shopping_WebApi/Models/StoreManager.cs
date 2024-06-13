namespace Shopping_WebApi.Models
{
    public class StoreManager : User
    {
       
        public List<Order> PendingOrders { get; set; }
        public List<Product> Inventory { get; set; }
        public Dictionary<Product, int> StockLevels { get; set; }

        // Constructor
        public StoreManager()
        {
            PendingOrders = new List<Order>();
            Inventory = new List<Product>();
            StockLevels = new Dictionary<Product, int>();
        }

        // Methods specific to StoreManager
        public void ProcessOrder(Order order)
        {
            // Implement logic to process the order
            //بعدا باید اضافه کنم وقتی پرداختش موفقیت آمیز بود سفارش نهایی بشه
            PendingOrders.Remove(order);
            // Update inventory, etc.
        }

        public void UpdateStockLevel(Product product, int quantity)
        {
            // Implement logic to update stock levels
            if (StockLevels.ContainsKey(product))
            {
                StockLevels[product] = quantity;
            }
            else
            {
                StockLevels.Add(product, quantity);
            }
        }

        public void AddProductToInventory(Product product)
        {
            // Implement logic to add a product to the inventory
            Inventory.Add(product);
            // Assume a default stock level for a new product
            StockLevels.Add(product, 0);
        }

        public void RemoveProductFromInventory(Product product)
        {
            // Implement logic to remove a product from the inventory
            Inventory.Remove(product);
            StockLevels.Remove(product);
        }

        // Additional methods can be added as needed
    }
}
