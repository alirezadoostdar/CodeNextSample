public class StockRecord
{
    public string Symbol
    {
        get => "ABCD";
    }

    private decimal[] prices = new decimal[]
    {
        10.0m, 20.0m, 30.0m, 40.0m, 50.0m, 60.0m, 70.0m
    };

    public decimal Average
    {
        get => prices.Sum() / prices.Length;
    }

    public decimal High
    {
        get => prices.Max();
    }

    public decimal Low
    {
        get => prices.Min();
    }

    public int Length => prices.Length;

    public decimal this[int index]
    {
        get => prices[index];
    }

    public decimal this[string day]
    {
        get
        {
            if (day =="mon")
                return prices[0];
            if (day == "tue")
                return prices[1];
            if (day == "wed")
                return prices[2];
            if (day == "thu")
                return prices[3];
            if ( day == "fri")
                return prices[4];
            if (day == "sat")
                return prices[5];
            if (day == "sun")
                return prices[6];
            throw new ArgumentOutOfRangeException("not valid input");
        }
    }
}