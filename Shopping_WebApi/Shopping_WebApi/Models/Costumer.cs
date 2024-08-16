namespace Shopping_WebApi.Models
{
    public  class Costumer : User
    {
        public string Address { get; set; }
        public string PostCode { get; set; }
        public Cart Cart { get; set; }

        public List<Order> OrderHistory { get; set; }
        public List<Product> WishList { get; set; }
     

      
    


}
}
