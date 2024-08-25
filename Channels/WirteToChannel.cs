using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Channels
{
    internal class WirteToChannel :BackgroundService
    {
        private readonly Channel<string> _channel;
        public WirteToChannel(Channel<string> channel)
        {
               _channel = channel;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                for (int i = 0; i < 100; i++)
                {
                    await _channel.Writer.WriteAsync(i.ToString());
                    Console.WriteLine($"write item {i}");
                    Task.Delay(1000).Wait();
                }
            }
        }
    }
}
