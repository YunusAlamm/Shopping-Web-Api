# Shopping Web API

## Overview

The Shopping Web API is a robust and extensible API built with .NET Core 8. It leverages the CQRS design pattern to facilitate a clear separation of concerns between reading and writing data, making it easy to manage entities related to an e-commerce platform, such as products, categories, and orders.


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
   git clone https://github.com/YunusAlamm/Shopping-Web-Api.git
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



