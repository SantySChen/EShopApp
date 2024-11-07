using Microsoft.EntityFrameworkCore;
using ReviewsMicroservice.ApplicationCore.Contacts.IRepositories;
using ReviewsMicroservice.Infrastructure.Data;
using ReviewsMicroservice.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EShopDbContext>(option =>
{
    //option.UseSqlServer(builder.Configuration.GetConnectionString("ReviewsMicroserviceDb"));
    option.UseSqlServer(Environment.GetEnvironmentVariable("ReviewConnectDB"));
});

builder.Services.AddScoped<ICustomerReviewRepositoryAsync, CustomerReviewRepositoryAsync>();

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
