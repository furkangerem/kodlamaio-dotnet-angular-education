using Autofac.Extensions.DependencyInjection;
using Autofac;
using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Autofac;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
/*
    // IoC Integration (In Java, it's Bean Configuration)
    // In Spring, it's Constructor Injection.
    builder.Services.AddSingleton<IBrandService, BrandManager>();
    builder.Services.AddSingleton<ICarService, CarManager>();
    builder.Services.AddSingleton<IColorService, ColorManager>();
    builder.Services.AddSingleton<ICustomerService, CustomerManager>();
    builder.Services.AddSingleton<IRentalService, RentalManager>();
    builder.Services.AddSingleton<IUserService, UserManager>();

    builder.Services.AddSingleton<IBrandDal, EfBrandDal>();
    builder.Services.AddSingleton<ICarDal, EfCarDal>();
    builder.Services.AddSingleton<IColorDal, EfColorDal>();
    builder.Services.AddSingleton<ICustomerDal, EfCustomerDal>();
    builder.Services.AddSingleton<IRentalDal, EfRentalDal>();
    builder.Services.AddSingleton<IUserDal, EfUserDal>();
*/

// We don't use these codes anymore. Autofac is implemented and it will create instance for us.
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
