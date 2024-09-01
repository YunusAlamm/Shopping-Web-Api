﻿namespace Shopping_WebApi.Features.PhysicalProducts.Dto
{
    public class PhysicalProductDto
    {
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public Core.Entities.Category Category { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public bool? IsSoldOut { get; set; }


        public Dictionary<string, string> Attributes { get; set; }

        public double Weight { get; set; }
        public string Dimensions { get; set; }
        public bool IsReturnable { get; set; }
    }
}