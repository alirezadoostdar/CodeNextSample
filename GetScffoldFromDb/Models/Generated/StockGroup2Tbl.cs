using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class StockGroup2Tbl
{
    public int GroupId { get; set; }

    public string GroupName { get; set; } = null!;

    public float? VisitPercent { get; set; }

    public virtual ICollection<StockTbl> StockTbls { get; set; } = new List<StockTbl>();
}
