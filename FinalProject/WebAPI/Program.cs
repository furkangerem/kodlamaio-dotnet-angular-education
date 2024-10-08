using Autofac.Extensions.DependencyInjection;
using Autofac;
using Business.Abstract;
using Business.Concrete;
using Business.DependecyResolver.Autofac;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// We don't use these codes anymore. Autofac is implemented and it will create instance for us.
/*
    // IoC Integration (In Java, it's Bean Configuration)
    // In Spring, it's Constructor Injection.
    builder.Services.AddSingleton<IProductService, ProductManager>();
    // We need to create a reference for IProductDal(). It's using in ProductManager;
    builder.Services.AddSingleton<IProductDal, EfProductDal>(); 
*/

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
            .ConfigureContainer<ContainerBuilder>(
                ContainerBuilder => { ContainerBuilder.RegisterModule(new AutofacBusinessModule()); });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();