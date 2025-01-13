using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class InfoGoodTypeTbl
{
    public string Title { get; set; } = null!;

    public int Code { get; set; }

    public virtual ICollection<StockTbl> StockTbls { get; set; } = new List<StockTbl>();
}
