using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Core.Models;
using Shopping_WebApi.Features.Categories.Mapping;
using Shopping_WebApi.Features.Category.Validators;
using Shopping_WebApi.Infrastructure.Data.DbContext;
using Shopping_WebApi.Infrastructure.Repositories;
using Shopping_WebApi.Infrastructures.EmailServices;
using Shopping_WebApi.Infrastructures.Repositories;
using Shopping_WebApi.Infrastructures.TelegramService;
using Shopping_WebApi.Infrastructures.ZarinPalGateway;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("ShoppingStore");
builder.Services.AddDbContext<Shopping_StoreContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddIdentityApiEndpoints<User>()
    .AddEntityFrameworkStores<Shopping_StoreContext>();
builder.Services.AddAuthentication(IdentityConstants.BearerScheme);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(ICommentRepository), typeof(CommentRepository));
builder.Services.AddScoped<ZarinPal.Class.Payment>();
builder.Services.AddScoped(typeof(IZarinpalService), typeof(ZarinpalService));
builder.Services.AddAutoMapper(typeof(CategoryMapping));
builder.Services.AddValidatorsFromAssemblyContaining(typeof(AddCategoryCommandValidator));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

var emailConfig = builder.Configuration
    .GetSection("EmailConfiguration")
    .Get<EmailConfiguration>();
builder.Services.AddSingleton(emailConfig);
builder.Services.AddScoped<IEmailService, EmailService>();

var telegramConfig = builder.Configuration
    .GetSection("TelegramBotConfiguration")
    .Get<TelegramBotConfiguration>();
builder.Services.AddSingleton(telegramConfig);
builder.Services.AddScoped<ITelegramService, TelegramService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Enable CORS
app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();
app.MapIdentityApi<User>();

app.Run();
