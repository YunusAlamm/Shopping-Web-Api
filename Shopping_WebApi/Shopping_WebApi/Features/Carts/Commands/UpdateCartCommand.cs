﻿using MediatR;
using Shopping_WebApi.Core.Entities;

namespace Shopping_WebApi.Features.Carts.Commands
{
    public class UpdateCartCommand: IRequest<bool>
    {
        public Guid Id { get; set; }
        public ICollection<Core.Entities.CartProduct> Products { get; set; }
        

    }
}
