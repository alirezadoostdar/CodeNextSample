using Channels;
using System.Threading.Channels;

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

//await Task.Run(async () =>
//{
//    for (int i = 0; i < 100; i++)
//    {
//        await channel.Writer.WriteAsync(i.ToString());
//        Console.WriteLine($"write item {i}");
//    }
//});

host.Run();
