using System.Collections.Concurrent;

String GetQuarterFromDate(DateTime date) => date.Month switch
{
    >= 1 and <= 3 => "Q1",
    >= 4 and <= 6 => "Q2",
    >= 7 and <= 9 => "Q3",
    >= 10 and <= 12 => "Q4",
    _ => throw new ArgumentOutOfRangeException(nameof(date),$"Unexpected month given : {date}")
};

Console.WriteLine(GetQuarterFromDate(new DateTime(2022,2,14)));
Console.WriteLine(GetQuarterFromDate(new DateTime(2022,7,19)));
Console.WriteLine(GetQuarterFromDate(new DateTime(2022,12,25)));
Console.WriteLine(GetQuarterFromDate(new DateTime(2022,4,1)));


void FirstOrSecondHalf(object dt)
{
    if (dt is DateTime { Month:> 6 })
    {
        Console.WriteLine("Date is in second half");
    }
    else if(dt is DateTime { Month:<=6 })
    {
        Console.WriteLine("Date is in the first half");
    }
}

FirstOrSecondHalf(new DateTime(2022, 7, 28));
FirstOrSecondHalf(new DateTime(2022, 4, 1));