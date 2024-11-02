
# Shopping Web API

## Overview

The Shopping Web API is a robust and extensible API built with .NET Core 8. It leverages the CQRS design pattern to facilitate a clear separation of concerns between reading and writing data, making it easy to manage entities related to an e-commerce platform, such as products, categories, and orders.

## Directory Structure

The project is organized into several key areas:

```
Core
├── Entities
│   ├── Cart.cs
│   ├── Cart_Product.cs
│   ├── Category.cs
│   ├── Comment.cs
│   ├── Customer.cs
│   ├── DigitalProduct.cs
│   ├── Order.cs
│   ├── OrderProduct.cs
│   ├── PhysicalProduct.cs
│   ├── Product.cs
│   ├── StoreManager.cs
│   ├── SystemManager.cs
│   └── User.cs
├── Models
│   ├── EmailConfiguration.cs
│   ├── RequestToPay.cs
│   ├── RequestToValidatePayment.cs
│   └── TelegramBotConfiguration.cs
├── Features
│   ├── CartProducts
│   ├── Carts
│   ├── Category
│   │   ├── CommandHandler
│   │   ├── Commands
│   │   ├── Dto
│   │   ├── Mapper
│   │   ├── Queries
│   │   ├── QueryHandlers
│   │   ├── Validators
│   │   └── CategoryManagement.cs
│   ├── Comments
│   ├── DigitalProducts
│   ├── OrderProducts
│   ├── Orders
│   ├── PaymentGateway
│   ├── PhysicalProducts
│   ├── SendEmail
│   └── TelegramFeatures
└── Infrastructures
    ├── Contexts
    ├── EmailServices
    ├── Repositories
    ├── TelegramService
    └── ZarinPalGateway
```

## Features

- **Entities**: Core business entities like `Cart`, `Product`, `Order`, and user-related models.
- **Models**: Configuration and payment request models to facilitate transactions.
- **Features**: A modular approach to managing different functionalities like cart management, category management, and order processing.
- **Infrastructures**: Implementations for context management, email services, repositories, and external service integrations (e.g., payment gateways).

## Getting Started

### Prerequisites

- .NET Core 8 SDK
- A suitable IDE (e.g., Visual Studio or VS Code)

### Installation

1. Clone the repository:
   ```bash
   git clone <repository-url>
   ```
2. Navigate to the project directory:
   ```bash
   cd Shopping_WebApi
   ```
3. Restore the dependencies:
   ```bash
   dotnet restore
   ```

### Running the API

To run the API, use the following command:

```bash
dotnet run
```

The API will start on `https://localhost:7168`.

### Swagger Documentation

The API documentation is available at:

```
https://localhost:7168/swagger/index.html
```

## Usage

### API Endpoints

The API provides various endpoints for managing categories, products, and orders. Here are some examples:

#### Category Management

- **Get All Categories**  
  `GET /api/category/Categories`

- **Get a Single Category**  
  `GET /api/category/Category`

- **Add a New Category**  
  `POST /api/category/AddCategory`

- **Update an Existing Category**  
  `PUT /api/category/UpdateCategory`

- **Delete a Category**  
  `DELETE /api/category/DeleteCategory`

### Example of a Controller

Here's an example of a controller for managing categories:

```csharp
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shopping_WebApi.Features.Categories.Queries;
using Shopping_WebApi.Features.Category.Commands;

namespace Shopping_WebApi.Features.Category
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryManagement : ControllerBase
    {
        private readonly ISender _sender;

        public CategoryManagement(ISender sender)
        {
            _sender = sender;
        }

        [HttpGet]
        [Route("Categories")]
        public async Task<IActionResult> Categories()
        {
            var query = new CategoriesQuery();
            var result = await _sender.Send(query);
            return Ok(result);
        }

        [HttpGet]
        [Route("Category")]
        public async Task<IActionResult> Category(CategoryQuery query)
        {
            var result = await _sender.Send(query);
            return Ok(result);
        }

        [HttpPost]
        [Route("AddCategory")]
        public async Task<IActionResult> AddCategory(AddCategoryCommand command)
        {
            var result = await _sender.Send(command);
            return Ok(result);
        }

        [HttpPut]
        [Route("UpdateCategory")]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryCommand command)
        {
            var result = await _sender.Send(command);
            return Ok(result);
        }

        [HttpDelete]
        [Route("DeleteCategory")]
        public async Task<IActionResult> DeleteCategory(DeleteCategoryCommand command)
        {
            var result = await _sender.Send(command);
            return Ok(result);
        }
    }
}
```

## Contributing

Contributions are welcome! Please feel free to submit a pull request or open an issue for any suggestions or improvements.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

Feel free to adjust any sections to better fit your project or to add more information that you think would be useful!
