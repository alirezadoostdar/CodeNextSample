using KeyedServiceInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddScoped<INotifyService,SmsService>();
//builder.Services.AddScoped<INotifyService,EmailService>();
//در زمان هایی که نیاز داریم چند اینجکشن از چند سرویس با یک امضا داشته باشیم می توانیم مانند زیر عمل کنیم
builder.Services.AddKeyedScoped<INotifyService,SmsService>(nameof(SmsService));
builder.Services.AddKeyedScoped<INotifyService,EmailService>(nameof(EmailService));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();




app.Run();


