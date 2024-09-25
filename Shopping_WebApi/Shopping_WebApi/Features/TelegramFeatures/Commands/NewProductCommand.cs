using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Shopping_WebApi.Features.TelegramFeatures.Commands
{
    public class NewProductCommand: IRequest<bool>
    {
        
        public string Name { get; set; }
        
        public decimal Price { get; set; }
        
        public string Description { get; set; }
    
    }
}
