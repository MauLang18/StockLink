using StockLink.Api.Extensions.Middleware;
using StockLink.Api.Extensions;
using StockLink.Application._6.Extensions;
using StockLink.Application.UseCase.Extensions;
using StockLink.Infrastructure._6.Extensions;
using StockLink.Persistence.Extensions;

var builder = WebApplication.CreateBuilder(args);
var Configuration = builder.Configuration;
// Add services to the container.
var Cors = "Cors";

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddInjectionInfrastructure(Configuration);
builder.Services.AddInjectionApplications(Configuration);
builder.Services.AddAuthentication(Configuration);
builder.Services.AddSwagger();

builder.Services.AddInjectionPersistence();
builder.Services.AddInjectionApplication();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: Cors,
        builder =>
        {
            builder.WithOrigins("*");
            builder.AllowAnyMethod();
            builder.AllowAnyHeader();
        });
});

var app = builder.Build();

app.UseCors(Cors);

// Configure the HTTP request pipeline.
if (app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.AddMiddleware();

app.MapControllers();

app.Run();