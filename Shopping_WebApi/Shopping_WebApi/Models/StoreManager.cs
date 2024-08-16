

namespace Shopping_WebApi.Models
{
    public class StoreManager : User
    {
        public SystemManager.Role ManagerRole { get; set; }

        public List<Order> PendingOrders { get; set; }
        public List<Order> CompletedSales { get; set; }
        public Dictionary<Product, int> Inventory { get; set; }
       
        



    }
}
