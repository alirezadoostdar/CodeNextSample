public  class program
{
    public static async Task Main(string[] args)
    {
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        Console.WriteLine(cancellationTokenSource.Token.IsCancellationRequested);
        await GetAllDataFromDataBaseAsync(cancellationTokenSource.Token);

        cancellationTokenSource.Cancel();
        await GetAllDataFromDataBaseAsync(cancellationTokenSource.Token);
    }

    public static async Task GetAllDataFromDataBaseAsync(CancellationToken cancellationToken)
    {
        HttpClient client = new();
        var result = await client.GetAsync("https://google.com", cancellationToken);
        Console.WriteLine(result);
    }
}
