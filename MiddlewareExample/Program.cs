using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
var logger = app.Logger;
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.Use(async (context, next) =>
{
    var myTimer = System.Diagnostics.Stopwatch.StartNew();
    logger.LogInformation($"==>> beginning request in");
    await next();
    logger.LogInformation($"==>> beginning request in {myTimer.ElapsedMilliseconds} ms");
});



app.Run( );

