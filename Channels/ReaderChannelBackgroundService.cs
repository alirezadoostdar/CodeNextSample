using System.Threading.Channels;

namespace Channels
{
    public class ReaderChannelBackgroundService : BackgroundService
    {
        private readonly Channel<string> _channel;

        public ReaderChannelBackgroundService(Channel<string> channel)
        {
            _channel = channel;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                await foreach (var item in _channel.Reader.ReadAllAsync())
                {
                    Console.WriteLine($"read item {item}");
                    Task.Delay(1000).Wait();
                }
                //await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
