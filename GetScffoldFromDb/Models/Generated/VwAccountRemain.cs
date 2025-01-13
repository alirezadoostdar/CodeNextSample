using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class VwAccountRemain
{
    public decimal? Remain { get; set; }

    public int Account { get; set; }

    public string? LastDate { get; set; }

    public decimal? Cur1Amount { get; set; }

    public decimal? Cur2Amount { get; set; }

    public decimal? Cur3Amount { get; set; }

    public DateTime? LastMiladiDate { get; set; }
}
