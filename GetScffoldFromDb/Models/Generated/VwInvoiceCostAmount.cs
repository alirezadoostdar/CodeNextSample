using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class VwInvoiceCostAmount
{
    public decimal? InvoiceAmount { get; set; }

    public decimal? CostAmount { get; set; }

    public decimal? TotalAmount { get; set; }

    public decimal? GoodVisitorAmount { get; set; }

    public decimal? TotalAmountWithMaliat { get; set; }

    public decimal? InvoiceAmountMaliat { get; set; }

    public int? FkInvoiceSysCode { get; set; }

    public double InvoiceWieght { get; set; }

    public int? GoodCount { get; set; }

    public double? SndUnitQty { get; set; }

    public double? FstUnitQty { get; set; }

    public decimal? InvoiceAmountAvarez { get; set; }

    public double TotalDiscount { get; set; }

    public double? AmountBeforeDiscount { get; set; }
}
