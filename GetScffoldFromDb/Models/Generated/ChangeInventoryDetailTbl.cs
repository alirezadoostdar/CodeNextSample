using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class ChangeInventoryDetailTbl
{
    public int? SysCode { get; set; }

    public int GoodSysCode { get; set; }

    public string? Comment { get; set; }

    public double? Quantity { get; set; }

    public string Unit { get; set; } = null!;

    public double? UnitRate { get; set; }

    public string? SerialNo { get; set; }

    public string? DateExpire { get; set; }

    public int? Size { get; set; }

    public int? Color { get; set; }

    public int? WareHouse { get; set; }

    public int? FkInventorySysCode { get; set; }

    public string? Field1 { get; set; }

    public string? Field2 { get; set; }

    public int? RowNo { get; set; }
}
