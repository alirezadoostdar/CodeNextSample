decimal GetGroupTicketPriceDiscount(int groupSize, DateTime visitDate)
    => (groupSize, visitDate.DayOfWeek) switch
    {
        (_, DayOfWeek.Saturday or DayOfWeek.Sunday) => 0.0m,
        ( >= 5 and < 10, DayOfWeek.Monday) => 0.20m,
        ( >= 10, DayOfWeek.Monday) => 0.30m,
        ( >= 5 and < 10, _) => 0.12m,
        ( >= 10, _) => 0.15m,
        ( <= 0, _) => throw new ArgumentException("Group size must be posistive number"),
        _ => 0.0m
    } ;

(int, DateTime)[] TestDiscountData = new[]
{
    (4,new DateTime(2022,9,3)),
    (7,new DateTime(2023,2,6)),
    (20,new DateTime(2023,4,17)),
    (15,new DateTime(2023,8,8)),
    (9,new DateTime(2023,8,9)),
};

foreach ((var size ,var data) in TestDiscountData)
{
    decimal discount = GetGroupTicketPriceDiscount (size, data);
    Console.WriteLine($"The discount for a {size}-person group on {data:ddd, MMM, d} is {discount}");
}
