using Microsoft.EntityFrameworkCore;
using OrderMicroservice.ApplicationCore.Contracts.IRepositories;
using OrderMicroservice.Infrastructure.Data;
using OrderMicroservice.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EShopDbContext>(option =>
{
    //option.UseSqlServer(builder.Configuration.GetConnectionString("OrderMicroserviceDb"));
    option.UseSqlServer(Environment.GetEnvironmentVariable("OrderConnectionDB"));
});

builder.Services.AddScoped<IOrderRepositoryAsync, OrderRepositoryAsync>();
builder.Services.AddScoped<ICustomerRepositoryAsync, CustomerRepositoryAsync>();
builder.Services.AddScoped<IPaymentRepositoryAsync, PaymentRepositoryAsync>();
builder.Services.AddScoped<IShoppingCartRepositoryAsync, ShoppingCartRepositoryAsync>();
builder.Services.AddScoped<IShoppingCartItemRepositoryAsync, ShoppingCartItemRepositoryAsync>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
