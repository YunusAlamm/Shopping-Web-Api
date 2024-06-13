namespace Shopping_WebApi.Models
{
    public  class RegularUser : User
    {
        public string Address { get; set; }
        public string PostCode { get; set; }
        public Cart Cart { get; set; }

        public List<Order> OrderHistory { get; set; }
        public List<Product> WishList { get; set; }
        public RegularUser() 
        {
            WishList = new List<Product>();
            OrderHistory = new List<Order>();
        }
        public void AddToWishList(Product product)
        {
            WishList.Add(product);
        }

        public void AddOrderToHistory(Order order)
        {
            OrderHistory.Add(order);
        }

      
    


}
}
