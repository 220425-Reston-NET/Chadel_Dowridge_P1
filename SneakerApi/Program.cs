using StoreBL;
using StoreDL;
using StoreModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Environment.GetEnvironmentVariable("Connection_String")

builder.Services.AddScoped<IRepository<Sneaker>, SQLSneakerRepository>(repo => new SQLSneakerRepository(builder.Configuration.GetConnectionString("Chadel Dowridge")));
builder.Services.AddScoped<IStoreBL, StoreBL2>();
builder.Services.AddScoped<IRepository<Store>, SQLStoreRepository>(repo => new SQLStoreRepository(builder.Configuration.GetConnectionString("Chadel Dowridge")));
builder.Services.AddScoped<IStoreBL, StoreBL2>();

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
