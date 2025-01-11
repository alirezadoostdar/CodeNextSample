using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class VwgoodReport
{
    public int GoodSysCode { get; set; }

    public double? Quantity { get; set; }

    public decimal Fee { get; set; }

    public double? UnitRate { get; set; }

    public string? SerialNo { get; set; }

    public string? InvoiceDate { get; set; }

    public int InvoiceSerialNo { get; set; }

    public int? FkDocsysCode { get; set; }

    public string? Size { get; set; }

    public string? WareHouse { get; set; }

    public string? Color { get; set; }

    public int? FkAccountSysCode { get; set; }

    public string Unit { get; set; } = null!;

    public string? Comment { get; set; }

    public string? Term { get; set; }

    public string? RecivedDate { get; set; }

    public bool? Amani { get; set; }

    public string GoodTitle { get; set; } = null!;

    public double? NetQuantity { get; set; }

    public string? AccountTitle { get; set; }

    public string CustomerName { get; set; } = null!;

    public string? InvoiceType { get; set; }

    public double? VisitorPerAmountRow { get; set; }

    public double? NetFee { get; set; }

    public double? VisitorFeeAmountRow { get; set; }

    public string InvoiceComment { get; set; } = null!;

    public string? DelivaredDate { get; set; }

    public string Uname { get; set; } = null!;

    public int InvoiceNo { get; set; }

    public string? Visitor { get; set; }

    public string? TempInvoice { get; set; }

    public string? BarCode { get; set; }

    public string? Code { get; set; }

    public string? GroupName1 { get; set; }

    public string? GroupName2 { get; set; }

    public int Sign { get; set; }

    public double? DiscountPercent { get; set; }

    public string? PersonGroup2 { get; set; }

    public string? PersonGroup1 { get; set; }

    public string? VisitorRowName { get; set; }

    public decimal Cost { get; set; }

    public decimal VisitorFee { get; set; }

    public float? VisitorPer { get; set; }

    public decimal? DiscountFee { get; set; }

    public int? VisitorSysCode { get; set; }

    public int Type { get; set; }

    public int CurrencyId { get; set; }

    public decimal CurRateDef { get; set; }

    public decimal BaseRate { get; set; }

    public string? FollowDate { get; set; }

    public decimal? CurFee { get; set; }

    public string? CurName { get; set; }

    public string? CultureName { get; set; }

    public int SysCode { get; set; }

    public int? InventorySerial { get; set; }

    public string? GroupName3 { get; set; }

    public byte FkYearId { get; set; }

    public int? FkProjectId { get; set; }
}
