using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class BarcodeTbl
{
    public int GoodCode { get; set; }

    public string? Field1 { get; set; }

    public string? Field2 { get; set; }

    public int SysId { get; set; }

    public int? Quantity { get; set; }

    public int? Color { get; set; }

    public int? Size { get; set; }

    public virtual StockTbl GoodCodeNavigation { get; set; } = null!;
}
