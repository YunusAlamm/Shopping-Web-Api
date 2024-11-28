using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Shopping_WebApi.Core.Entities;
using Shopping_WebApi.Core.Models;
using Shopping_WebApi.Features.Categories.Mapping;
using Shopping_WebApi.Features.Category.Validators;
using Shopping_WebApi.Infrastructure.Data.DbContext;
using Shopping_WebApi.Infrastructure.Repositories;
using Shopping_WebApi.Infrastructures.Repositories;
using Shopping_WebApi.Infrastructures.Services.EmailServices;
using Shopping_WebApi.Infrastructures.Services.JwtTokenService;
using Shopping_WebApi.Infrastructures.Services.TelegramService;
using Shopping_WebApi.Infrastructures.Services.ZarinPalGateway;
using System.Reflection;
using System.Text;

var builder = WebApplication.CreateBuilder(args);


var emailConfig = builder.Configuration.GetSection("EmailConfiguration").Get<EmailConfiguration>();
builder.Services.AddSingleton(emailConfig);
builder.Services.AddScoped<IEmailSender, EmailSender>();


var connectionString = builder.Configuration.GetConnectionString("ShoppingStore");
builder.Services.AddDbContext<Shopping_StoreContext>(options =>
    options.UseNpgsql(connectionString));




builder.Services.AddIdentity<User, IdentityRole>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
})
    .AddEntityFrameworkStores<Shopping_StoreContext>()
    .AddDefaultTokenProviders();



builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = "Bearer";
    options.DefaultChallengeScheme = "Bearer";
})
.AddJwtBearer("Bearer",options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["JWT:Issuer"],
        ValidAudience = builder.Configuration["JWT:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:SecretKey"]))
    };
});




builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme (Example: 'Bearer 12345abcdef')",
        Name = "Authorization",
        In = Microsoft.OpenApi.Models.ParameterLocation.Header,
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
    {
        {
            new Microsoft.OpenApi.Models.OpenApiSecurityScheme
            {
                Reference = new Microsoft.OpenApi.Models.OpenApiReference
                {
                    Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
        }
    });
});




builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(ICommentRepository), typeof(CommentRepository));
builder.Services.AddScoped<ZarinPal.Class.Payment>();
builder.Services.AddScoped(typeof(IZarinpalService), typeof(ZarinpalService));
builder.Services.AddAutoMapper(typeof(CategoryMapping));
builder.Services.AddValidatorsFromAssemblyContaining(typeof(AddCategoryCommandValidator));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));





var telegramConfig = builder.Configuration
    .GetSection("TelegramBotConfiguration")
    .Get<TelegramBotConfiguration>();
builder.Services.AddSingleton(telegramConfig);
builder.Services.AddScoped<ITelegramService, TelegramService>();

builder.Services.AddScoped<ITokenService, TokenService>();

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
app.UseCors("AllowAll");
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
// app.MapIdentityApi<User>();

app.Run();
