using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwgoodReport
{
    public int GoodSysCode { get; set; }

    public double? Quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal Fee { get; set; }

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
    public string? WareHouse { get; set; }

    [StringLength(1000)]
    public string? Color { get; set; }

    [Column("FK_AccountSysCode")]
    public int? FkAccountSysCode { get; set; }

    [StringLength(100)]
    public string Unit { get; set; } = null!;

    [StringLength(300)]
    public string? Comment { get; set; }

    [StringLength(1000)]
    public string? Term { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? RecivedDate { get; set; }

    public bool? Amani { get; set; }

    [StringLength(1000)]
    public string GoodTitle { get; set; } = null!;

    public double? NetQuantity { get; set; }

    public string? AccountTitle { get; set; }

    [StringLength(300)]
    public string CustomerName { get; set; } = null!;

    [StringLength(200)]
    public string? InvoiceType { get; set; }

    public double? VisitorPerAmountRow { get; set; }

    public double? NetFee { get; set; }

    public double? VisitorFeeAmountRow { get; set; }

    [StringLength(300)]
    public string InvoiceComment { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? DelivaredDate { get; set; }

    [Column("UName")]
    [StringLength(1000)]
    public string Uname { get; set; } = null!;

    public int InvoiceNo { get; set; }

    public string? Visitor { get; set; }

    [StringLength(10)]
    public string? TempInvoice { get; set; }

    [StringLength(100)]
    public string? BarCode { get; set; }

    [StringLength(100)]
    public string? Code { get; set; }

    [StringLength(100)]
    public string? GroupName1 { get; set; }

    [StringLength(100)]
    public string? GroupName2 { get; set; }

    public int Sign { get; set; }

    public double? DiscountPercent { get; set; }

    [Column("personGroup2")]
    [StringLength(100)]
    public string? PersonGroup2 { get; set; }

    [Column("personGroup1")]
    [StringLength(100)]
    public string? PersonGroup1 { get; set; }

    public string? VisitorRowName { get; set; }

    [Column(TypeName = "money")]
    public decimal Cost { get; set; }

    [Column(TypeName = "money")]
    public decimal VisitorFee { get; set; }

    public float? VisitorPer { get; set; }

    [Column(TypeName = "money")]
    public decimal? DiscountFee { get; set; }

    public int? VisitorSysCode { get; set; }

    public int Type { get; set; }

    [Column("CurrencyID")]
    public int CurrencyId { get; set; }

    [Column(TypeName = "money")]
    public decimal CurRateDef { get; set; }

    [Column(TypeName = "money")]
    public decimal BaseRate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? FollowDate { get; set; }

    [Column(TypeName = "money")]
    public decimal? CurFee { get; set; }

    [StringLength(50)]
    public string? CurName { get; set; }

    [StringLength(50)]
    public string? CultureName { get; set; }

    public int SysCode { get; set; }

    public int? InventorySerial { get; set; }

    [StringLength(100)]
    public string? GroupName3 { get; set; }

    [Column("Fk_YearId")]
    public byte FkYearId { get; set; }

    [Column("Fk_ProjectID")]
    public int? FkProjectId { get; set; }
}
