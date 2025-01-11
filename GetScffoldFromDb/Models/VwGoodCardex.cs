using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class VwGoodCardex
{
    public string? SerialNo { get; set; }

    public string? SizeName { get; set; }

    public string? WareHouseName { get; set; }

    public string? ColorName { get; set; }

    public string Title { get; set; } = null!;

    public double? NetQuantity { get; set; }

    public int GoodSyscode { get; set; }

    public bool? Amani { get; set; }

    public int? FkDocsysCode { get; set; }

    public string? InvoiceDate { get; set; }

    public int? InvoiceSerialNo { get; set; }

    public string? Type { get; set; }

    public byte? FkYearId { get; set; }

    public int? FkProjectId { get; set; }
}
