using Interview.Business;
using Interview.Business.Abstract;
using Interview.DataAccess;
using Interview.DataAccess.Abstract;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IMusteriService,MusteriManager>();
builder.Services.AddScoped<IMusteriDal, EfMusteriDal>();

builder.Services.AddScoped<ISepetService, SepetManager>();
builder.Services.AddScoped<ISepetDal, EfSepetDal>();

builder.Services.AddScoped<ISepetUrunService, SepetUrunManager>();
builder.Services.AddScoped<ISepetUrunDal, EfSepetUrunDal>();

builder.Services.AddScoped<ITestVeriService, TestVeriManager>();
builder.Services.AddScoped<ITestVerisiDal, EfTestVerisiDal>();

builder.Services.AddScoped<IAnalizService, AnalizManager>();
builder.Services.AddScoped<IAnalizDal, EfAnalizDal>();



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
