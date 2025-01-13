using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class VwInventoryGoodDetailRemain
{
    public int GoodSysCode { get; set; }

    public double? Remain { get; set; }

    public int? Color { get; set; }

    public int? Size { get; set; }

    public string? SerialNo { get; set; }

    public int? WareHouse { get; set; }

    public string? DateExpire { get; set; }
}
