using MediatR;
using MicroRabbit.Banking.Application.Interfaces;
using MicroRabbit.Banking.Application.Services;
using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Data.Repository;
using MicroRabbit.Banking.Domian.Interfaces;

using MicroRabbit.Infra.IoC;
using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
public class Program
{
    public static void Main(string[] args)
    {
        CreateWebHostBuilder(args).Build().Run();
    }

    public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
            .UseStartup<MicroRabbit.Banking.Api.Startup>();
}

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.


////RegisterServices(builder.Services);




//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();

//builder.Services.AddSwaggerGen();
//builder.Services.AddDbContext<BankingDbContext>(
//        o => o.UseNpgsql(builder.Configuration.GetConnectionString("BankingDbConnection"))
//    );


//builder.Services.AddSwaggerGen(c =>
//{
//    c.SwaggerDoc("v1", new OpenApiInfo 
//    { 
//        Title = "Banking Microservice",
//        Version="v1"
//    });
//});


////builder.Services.AddMediatR(typeof(Program));

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI(c =>
//     {
//         // set route prefix to openapi, e.g. http://localhost:8080/swagger/index.html
//         //c.RoutePrefix = "swagger";
//         c.SwaggerEndpoint("/swagger/v1/swagger.json", "Banking Microservice V1");
//     });
//}


//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();
