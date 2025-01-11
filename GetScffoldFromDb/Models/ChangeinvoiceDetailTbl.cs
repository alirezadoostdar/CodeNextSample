using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class ChangeinvoiceDetailTbl
{
    public int GoodSysCode { get; set; }

    public string? Comment { get; set; }

    public double? Quantity { get; set; }

    public decimal Fee { get; set; }

    public string Unit { get; set; } = null!;

    public double? UnitRate { get; set; }

    public decimal? UserPrice { get; set; }

    public string? SerialNo { get; set; }

    public int? Size { get; set; }

    public int? Color { get; set; }

    public int? WareHouse { get; set; }

    public int FkInvoiceSysCode { get; set; }

    public double? DiscountPercent { get; set; }

    public int SysCode { get; set; }

    public string? Term { get; set; }

    public int? RowNo { get; set; }

    public int? OnChangeUserId { get; set; }

    public DateTime? OnChangeSysDate { get; set; }

    public bool? IsUpDated { get; set; }

    public string? OnChangeSysShamsiDate { get; set; }

    public double? DiscountPercent2 { get; set; }

    public double? MaliatArzeshAfzoodeh { get; set; }

    public double? Avarez { get; set; }

    public string? DateExpire { get; set; }
}
