using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwWareHouseTransferComplete
{
    public int GoodSysCode { get; set; }

    public double? Quantity { get; set; }

    public int Fee { get; set; }

    public double? UnitRate { get; set; }

    [StringLength(100)]
    public string? SerialNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? InvoiceDate { get; set; }

    public int InvoiceSerialNo { get; set; }

    [Column("FK_DocsysCode")]
    public int? FkDocsysCode { get; set; }

    [StringLength(1000)]
    public string? Size { get; set; }

    [StringLength(1000)]
    public string WareHouse { get; set; } = null!;

    [StringLength(1000)]
    public string? Color { get; set; }

    [Column("FK_AccountSysCode")]
    public int? FkAccountSysCode { get; set; }

    [StringLength(100)]
    public string Unit { get; set; } = null!;

    [StringLength(300)]
    public string? Comment { get; set; }

    [StringLength(1000)]
    public string Term { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string RecivedDate { get; set; } = null!;

    public int Amani { get; set; }

    [StringLength(1000)]
    public string GoodTitle { get; set; } = null!;

    public double? NetQuantity { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string AccountTitle { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string CustomerName { get; set; } = null!;

    [StringLength(17)]
    public string InvoiceType { get; set; } = null!;

    public int VisitorPerAmountRow { get; set; }

    public int NetFee { get; set; }

    public int VisitorFeeAmountRow { get; set; }

    [StringLength(300)]
    public string InvoiceComment { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string DelivaredDate { get; set; } = null!;

    [Column("UName")]
    [StringLength(1000)]
    public string Uname { get; set; } = null!;

    public int? InvoiceNo { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string Visitor { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string TempInvoice { get; set; } = null!;

    [StringLength(100)]
    public string? BarCode { get; set; }

    [StringLength(100)]
    public string? Code { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string GroupName1 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string GroupName2 { get; set; } = null!;

    public int Sign { get; set; }

    public int DiscountPercent { get; set; }

    [Column("personGroup2")]
    [StringLength(1)]
    [Unicode(false)]
    public string PersonGroup2 { get; set; } = null!;

    [Column("personGroup1")]
    [StringLength(1)]
    [Unicode(false)]
    public string PersonGroup1 { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string VisitorRowName { get; set; } = null!;

    public int Cost { get; set; }

    public int VisitorFee { get; set; }

    public int VisitorPer { get; set; }

    public int DiscountFee { get; set; }

    public int? VisitorSysCode { get; set; }

    public int Type { get; set; }

    [Column("CurrencyID")]
    public int CurrencyId { get; set; }

    public int CurRateDef { get; set; }

    public int BaseRate { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string FollowDate { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string CurFee { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string CurName { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string CultureName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? DateExpire { get; set; }

    [Column("WareHouseID")]
    public int? WareHouseId { get; set; }

    public int? SndNetQuantity { get; set; }

    public int? InventorySerial { get; set; }

    [Column("Fk_YearId")]
    public byte FkYearId { get; set; }
}
