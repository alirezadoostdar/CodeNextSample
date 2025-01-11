using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class WarehouseCountingDetail
{
    public int Id { get; set; }

    public int RowNo { get; set; }

    public int FkWarehouseCountingId { get; set; }

    public int GoodSysCode { get; set; }

    public double RealQty { get; set; }

    public double RemainQty { get; set; }

    public double Quantity { get; set; }

    public double RemainInvQty { get; set; }

    public double InvQuantity { get; set; }

    public string Unit { get; set; } = null!;

    public double UnitRate { get; set; }

    public int? Warehouse { get; set; }

    public string? SerialNo { get; set; }

    public string? DateExpire { get; set; }

    public int? Size { get; set; }

    public int? Color { get; set; }

    public decimal Fee { get; set; }

    public string? Comment { get; set; }

    public virtual GoodColorTbl? ColorNavigation { get; set; }

    public virtual WarehouseCounting FkWarehouseCounting { get; set; } = null!;

    public virtual StockTbl GoodSysCodeNavigation { get; set; } = null!;

    public virtual GoodSizeTbl? SizeNavigation { get; set; }

    public virtual WareHouseTbl? WarehouseNavigation { get; set; }
}
