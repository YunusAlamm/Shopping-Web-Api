﻿namespace Shopping_WebApi.Models
{
    public  class Customer : User
    {

        public Cart Cart { get; set; }

        public List<Order> OrderHistory { get; set; }
        public List<Product> WishList { get; set; }
     

      
    


    }
}