using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class VwSysGoodRemainDetail
{
    public double? Qty { get; set; }

    public int GoodSysCode { get; set; }

    public int? Size { get; set; }

    public int? Color { get; set; }

    public int? WareHouse { get; set; }

    public string? SerialNo { get; set; }
}
