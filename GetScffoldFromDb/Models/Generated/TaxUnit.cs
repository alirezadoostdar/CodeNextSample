using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class TaxUnit
{
    public int Id { get; set; }

    public string Unit { get; set; } = null!;

    public virtual ICollection<StockTbl> StockTbls { get; set; } = new List<StockTbl>();
}
