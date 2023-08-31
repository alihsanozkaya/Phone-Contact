using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using Phone_Contact.Business.Mappings;
using Phone_Contact.DataAccess.Abstract;
using Phone_Contact.DataAccess.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#region AutoMapper
var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new PersonProfile());
    mc.AddProfile(new PhoneProfile());

});
var mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);
#endregion

#region Autofac
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
#endregion

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


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
