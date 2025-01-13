using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class VwCompleteRemainAnbarTransferByTitle
{
    public double? Remain { get; set; }

    public string? WareHouseName { get; set; }

    public string? ColorName { get; set; }

    public string? SizeName { get; set; }

    public string? SerialNo { get; set; }

    public string? DateExpire { get; set; }

    public int? Color { get; set; }

    public int? Size { get; set; }

    public int? WareHouse { get; set; }

    public int GoodSysCode { get; set; }
}
