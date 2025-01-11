using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwInvoiceDetailCostPersonDocDetail
{
    public int InvoiceSerialNo { get; set; }

    public int? DetailCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? InvoiceDate { get; set; }

    [StringLength(1000)]
    public string? Title { get; set; }

    public double? Amount { get; set; }

    public double? Quantity { get; set; }

    public double? Fee { get; set; }

    [StringLength(300)]
    public string Comment { get; set; } = null!;

    public double? DiscountAmount { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string Unit { get; set; } = null!;

    public int? RowNo { get; set; }

    public int Sign { get; set; }
}
