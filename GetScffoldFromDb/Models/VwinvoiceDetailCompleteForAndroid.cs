using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class VwinvoiceDetailCompleteForAndroid
{
    public int GoodSysCode { get; set; }

    public double? Fee { get; set; }

    public int? Size { get; set; }

    public int? Color { get; set; }

    public int? FkDocsysCode { get; set; }

    public string? InvoiceDate { get; set; }

    public int InvoiceSerialNo { get; set; }

    public int? FkAccountSysCode { get; set; }

    public double? Quantity { get; set; }

    public string Unit { get; set; } = null!;

    public double? UnitRate { get; set; }

    public string? VisitorName { get; set; }

    public string? InvoiceType { get; set; }

    public string? InvoiceComment { get; set; }

    public string GoodName { get; set; } = null!;

    public string? SizeName { get; set; }

    public string? ColorName { get; set; }

    public string? WareHouseName { get; set; }

    public int? VisitorSyscode { get; set; }

    public int Sign { get; set; }

    public int Type { get; set; }
}
