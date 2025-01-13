using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class VwInvoiceDetailCostPersonDocDetail
{
    public int InvoiceSerialNo { get; set; }

    public int? DetailCode { get; set; }

    public string? InvoiceDate { get; set; }

    public string? Title { get; set; }

    public double? Amount { get; set; }

    public double? Quantity { get; set; }

    public double? Fee { get; set; }

    public string Comment { get; set; } = null!;

    public double? DiscountAmount { get; set; }

    public string Unit { get; set; } = null!;

    public int? RowNo { get; set; }

    public int Sign { get; set; }
}
