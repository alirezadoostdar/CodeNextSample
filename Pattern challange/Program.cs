using Pattern_challange;

SecuritiesTrade[] tradeList = new SecuritiesTrade[]
{
    new StockTrade(){symbol = "ABCD" , quantity=1200,price = 27.81m},
    new BondTrade(){name = "ABCD" , duration = 20 , quantity=1200,price = 27.81m}
};


foreach (var trade in tradeList)
{
	try
	{
		CommitionCalculator.PrintTradeCommision(trade);
	}
	catch (ArgumentException e)
	{
        Console.WriteLine($"{e.Message}");
    }
}