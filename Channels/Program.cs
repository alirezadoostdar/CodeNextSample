using BenchmarkDotNet.Running;
using Channels;
using System.Threading.Channels;

//channels have behavior same rabbitMQ and they are prduser and consumer senario
//they have two type bounded and unbounded type
//in bounded type you can set cpacity for it and in unbounded type there in no limited for that
//in bounded type there are 4 mode to can set by FullMode peroperty
var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddSingleton(Channel.CreateBounded(new BoundedChannelOptions(20)
{
    FullMode = BoundedChannelFullMode.Wait
}, (string item) =>
{
    Console.WriteLine($"dropped item {item}");
}));

builder.Services.AddHostedService<ReaderChannelBackgroundService>();
builder.Services.AddHostedService<WirteToChannel>();
var host = builder.Build();

var channel = host.Services.GetService<Channel<string>>();


//BenchmarkRunner.Run<ChannelsBenchmark>();
host.Run();
