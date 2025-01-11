using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class VwWareHouseTransferComplete
{
    public int GoodSysCode { get; set; }

    public double? Quantity { get; set; }

    public int Fee { get; set; }

    public double? UnitRate { get; set; }

    public string? SerialNo { get; set; }

    public string? InvoiceDate { get; set; }

    public int InvoiceSerialNo { get; set; }

    public int? FkDocsysCode { get; set; }

    public string? Size { get; set; }

    public string WareHouse { get; set; } = null!;

    public string? Color { get; set; }

    public int? FkAccountSysCode { get; set; }

    public string Unit { get; set; } = null!;

    public string? Comment { get; set; }

    public string Term { get; set; } = null!;

    public string RecivedDate { get; set; } = null!;

    public int Amani { get; set; }

    public string GoodTitle { get; set; } = null!;

    public double? NetQuantity { get; set; }

    public string AccountTitle { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public string InvoiceType { get; set; } = null!;

    public int VisitorPerAmountRow { get; set; }

    public int NetFee { get; set; }

    public int VisitorFeeAmountRow { get; set; }

    public string InvoiceComment { get; set; } = null!;

    public string DelivaredDate { get; set; } = null!;

    public string Uname { get; set; } = null!;

    public int? InvoiceNo { get; set; }

    public string Visitor { get; set; } = null!;

    public string TempInvoice { get; set; } = null!;

    public string? BarCode { get; set; }

    public string? Code { get; set; }

    public string GroupName1 { get; set; } = null!;

    public string GroupName2 { get; set; } = null!;

    public int Sign { get; set; }

    public int DiscountPercent { get; set; }

    public string PersonGroup2 { get; set; } = null!;

    public string PersonGroup1 { get; set; } = null!;

    public string VisitorRowName { get; set; } = null!;

    public int Cost { get; set; }

    public int VisitorFee { get; set; }

    public int VisitorPer { get; set; }

    public int DiscountFee { get; set; }

    public int? VisitorSysCode { get; set; }

    public int Type { get; set; }

    public int CurrencyId { get; set; }

    public int CurRateDef { get; set; }

    public int BaseRate { get; set; }

    public string FollowDate { get; set; } = null!;

    public string CurFee { get; set; } = null!;

    public string CurName { get; set; } = null!;

    public string CultureName { get; set; } = null!;

    public string? DateExpire { get; set; }

    public int? WareHouseId { get; set; }

    public int? SndNetQuantity { get; set; }

    public int? InventorySerial { get; set; }

    public byte FkYearId { get; set; }
}
