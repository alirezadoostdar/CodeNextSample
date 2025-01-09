StockRecord stock1 = new StockRecord();
Console.WriteLine($"Average: {stock1.Average:C}");
Console.WriteLine($"High: {stock1.High:C}");
Console.WriteLine($"Low: {stock1.Low:C}");
Console.WriteLine($"Days: {stock1.Length}");


for( int i = 0; i < stock1.Length; i++)
{
    decimal val = stock1[i];
    Console.WriteLine($"val: {val:C}");
}

Console.WriteLine($"weekly: {stock1["wed"]:C}");
Console.WriteLine($"weekly: {stock1["sat"]:C}");
