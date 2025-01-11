using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class VwWarehouseCountingDetail
{
    public int Id { get; set; }

    public int Code { get; set; }

    public int? FkDocSysCodeIn { get; set; }

    public int? FkDocSysCodeOut { get; set; }

    public string ShamsiDate { get; set; } = null!;

    public DateTime MiladiDate { get; set; }

    public bool IsTemp { get; set; }

    public string? Comment { get; set; }

    public string RegShamsiDate { get; set; } = null!;

    public double Quantity { get; set; }

    public double RemainQty { get; set; }

    public double RealQty { get; set; }

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

    public int GoodSysCode { get; set; }

    public int RowNo { get; set; }

    public string? GoodTitle { get; set; }

    public string? WareHouseName { get; set; }

    public string? SizeName { get; set; }

    public string? ColorName { get; set; }

    public double? TotalFee { get; set; }

    public int? FkProjectId { get; set; }

    public byte FkYearId { get; set; }
}
