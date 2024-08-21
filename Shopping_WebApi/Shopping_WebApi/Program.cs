using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Infrastructure.Data.DbContext;
using Shopping_WebApi.Infrastructure.Repositories;


var builder = WebApplication.CreateBuilder(args);



var ConectionString = builder.Configuration.GetConnectionString("ShoppingStore");
builder.Services.AddDbContext<Shopping_StoreContext>(options => options.UseNpgsql(ConectionString));


builder.Services.AddIdentityApiEndpoints<User>()
    .AddEntityFrameworkStores<Shopping_StoreContext>();
builder.Services.AddAuthentication(IdentityConstants.BearerScheme);


builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapIdentityApi<User>();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();
