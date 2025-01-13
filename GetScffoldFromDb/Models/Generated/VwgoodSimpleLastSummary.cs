using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class VwgoodSimpleLastSummary
{
    public string? LastDate { get; set; }

    public double? LastFee { get; set; }

    public double? FeeNoCost { get; set; }

    public string LastSeller { get; set; } = null!;

    public int GoodSysCode { get; set; }

    public long? Rank { get; set; }
}
