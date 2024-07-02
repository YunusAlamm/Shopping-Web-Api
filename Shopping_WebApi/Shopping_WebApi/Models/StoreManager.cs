

namespace Shopping_WebApi.Models
{
    public class StoreManager : User
    {
        public SystemManager.Role ManagerRole { get; set; }

        public List<Order> PendingOrders { get; set; }
        public List<Order> CompletedSales { get; set; }
        public Dictionary<Product, int> Inventory { get; set; }
       
        // Constructor
        public StoreManager()
        {
            PendingOrders = new List<Order>();
            
            Inventory = new Dictionary<Product, int>();
            CompletedSales = new List<Order>();
        }

        // Methods specific to StoreManager
        public void ProcessOrder(Order order)
        {
            
            //بعدا باید اضافه کنم وقتی پرداختش موفقیت آمیز بود سفارش نهایی بشه
            PendingOrders.Remove(order);
            CompletedSales.Add(order);
            


            // Update inventory, etc.
        }

      
       


        public void AddProductToInventory(Product product, int quantity = 1)
        {
            // Implement logic to add a product to the inventory
            Inventory.Add(product,quantity);
            
        }

        public void UpdateStockAfterSale(Order order)
        {
            foreach (var product in order.Products)
            {
                // Check if the product exists in the inventory before attempting to adjust it
                if (Inventory.ContainsKey(product.Key))
                {
                    
                    // Decrement the quantity
                    Inventory[product.Key]--;

                    // If the quantity reaches 0, remove the product from the inventory
                    if (Inventory[product.Key] == 0)
                    {
                        Inventory.Remove(product.Key);
                    }


                }
            }
        }




    }
}
