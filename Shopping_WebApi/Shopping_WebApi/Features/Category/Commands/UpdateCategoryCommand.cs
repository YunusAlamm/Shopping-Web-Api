﻿using MediatR;
using Shopping_WebApi.Core.Entities;

namespace Shopping_WebApi.Features.Category.Commands
{
    public class UpdateCategoryCommand: IRequest<bool>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Product>? Products { get; set; }
    }
}
