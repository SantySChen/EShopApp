using Microsoft.EntityFrameworkCore;
using PromotionsMicroservice.ApplicatonCore.Contracts.IRepositories;
using PromotionsMicroservice.Infrastructure.Data;
using PromotionsMicroservice.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EShopDbContext>(option =>
{
    //option.UseSqlServer(builder.Configuration.GetConnectionString("PromotionsMicroserviceDb"));
    option.UseSqlServer(Environment.GetEnvironmentVariable("PromotionConnectDB"));
});

builder.Services.AddScoped<IPromotionRepositoryAsync, PromotionRepositoryAsync>();

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
