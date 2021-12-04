using System.Text.Json;
using Microsoft.AspNetCore.Http.Json;
using WebApplication2;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
builder.Services.AddSingleton<ICatalog, InMemoryCatalog>();
builder.Services.Configure<JsonOptions>(
    options =>
    {
        options.SerializerOptions.WriteIndented = true;
    });
app.MapGet("/catalog", (InMemoryCatalog catalog) => catalog.GetProducts()
);

app.Run();