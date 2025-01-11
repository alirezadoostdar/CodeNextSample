using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwInvoiceCostAmount
{
    [Column(TypeName = "money")]
    public decimal? InvoiceAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? CostAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? TotalAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? GoodVisitorAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? TotalAmountWithMaliat { get; set; }

    [Column(TypeName = "money")]
    public decimal? InvoiceAmountMaliat { get; set; }

    [Column("FK_InvoiceSysCode")]
    public int? FkInvoiceSysCode { get; set; }

    public double InvoiceWieght { get; set; }

    public int? GoodCount { get; set; }

    [Column("SndUnitQTY")]
    public double? SndUnitQty { get; set; }

    [Column("FstUnitQTY")]
    public double? FstUnitQty { get; set; }

    [Column(TypeName = "money")]
    public decimal? InvoiceAmountAvarez { get; set; }

    public double TotalDiscount { get; set; }

    public double? AmountBeforeDiscount { get; set; }
}
