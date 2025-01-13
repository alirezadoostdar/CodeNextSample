using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class CurrencyTbl
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string CultureName { get; set; } = null!;

    public string? Title { get; set; }

    public decimal? Price { get; set; }

    public double? Change { get; set; }

    public DateTime? UpdateTime { get; set; }

    public string? ShamsiUpdateDate { get; set; }
}
