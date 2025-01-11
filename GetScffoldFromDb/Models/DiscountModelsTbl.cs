using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class DiscountModelsTbl
{
    public int SysCode { get; set; }

    public string? Title { get; set; }

    public decimal? GetAmmount { get; set; }

    public decimal? SharjAmmount { get; set; }

    public double? DisPer { get; set; }
}
