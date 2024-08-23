using GetMehrData;
using GetMehrData.Models;
using GetMehrData.Services;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

builder.Services.Configure<AppSettings>(builder.Configuration);
var settings = builder.Configuration.Get<AppSettings>();
builder.Services.AddSingleton<MehrDbContext>();
builder.Services.AddScoped<GoodService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}
app.UseHttpsRedirection();
app.UseHttpsRedirection();


app.MapGet("/GetList", async (GoodService GoodService) =>
{
    var list = await GoodService.GetList();
    foreach (var item in list)
    {
        using (HttpClient httpclient = new HttpClient())
        {
            httpclient.BaseAddress = new Uri("http://localhost:5091/");
            var newItem = new AddItemToCatalogViewModel
            {
                name = item.title,
                description = item.categoryTitle,
                maxStockThreshold = new Random().Next(4, 4),
                brandId = new Random().Next(1, 2),
                catalogId = new Random().Next(1, 2),
            };
            var res = httpclient.PostAsJsonAsync<AddItemToCatalogViewModel>("api/v1/items", newItem).Result;
        }
       

    }
    return list;
});

app.Run();
