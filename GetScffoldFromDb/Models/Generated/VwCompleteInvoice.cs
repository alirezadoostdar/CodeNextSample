using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class VwCompleteInvoice
{
    public int GoodSysCode { get; set; }

    public string? DetailComment { get; set; }

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

    public string CustomerName { get; set; } = null!;

    public int? FkAccountSysCode { get; set; }

    public string Comment { get; set; } = null!;

    public int InvoiceSerialNo { get; set; }

    public string? RecivedDate { get; set; }

    public string? DelivaredDate { get; set; }

    public string? PaymentDate { get; set; }

    public string? InvoiceDate { get; set; }

    public int? FkDocsysCode { get; set; }

    public string? ArchiveName { get; set; }

    public int UserNo { get; set; }

    public int InvoiceNo { get; set; }

    public int? VisitorSyscode { get; set; }

    public float? VisitorPer { get; set; }

    public decimal? VisitorAmount { get; set; }

    public DateTime SysDate { get; set; }

    public int Sign { get; set; }

    public int Type { get; set; }

    public bool? Amani { get; set; }

    public double? DiscountPercent2 { get; set; }

    public byte FkYearId { get; set; }

    public int? FkProjectId { get; set; }
}
