using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class TransferWareHoseDetailTbl
{
    public int GoodSysCode { get; set; }

    public string? Comment { get; set; }

    public double? Quantity { get; set; }

    public string Unit { get; set; } = null!;

    public double? UnitRate { get; set; }

    public string? SerialNo { get; set; }

    public int? Size { get; set; }

    public int? Color { get; set; }

    public int? WareHouseFrom { get; set; }

    public int? WareHouseTo { get; set; }

    public int FkTransferSysCode { get; set; }

    public int SysCode { get; set; }

    public int? RowNo { get; set; }

    public string? DateExpire { get; set; }

    public virtual TransferWareHoseTbl FkTransferSysCodeNavigation { get; set; } = null!;

    public virtual StockTbl GoodSysCodeNavigation { get; set; } = null!;
}
