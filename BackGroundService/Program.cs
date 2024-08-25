using BackGroundService;
//for long running task is better we use background service
//for short runnig task is better we use IhostedService
//backgroundService inherit from IhostedService 
//
//
//
//
var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();
builder.Services.AddHostedService<HostBackGround>();
var host = builder.Build();
host.Run();
