using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwinvoiceDetailComplete
{
    public int GoodSysCode { get; set; }

    public double? NetQuantity { get; set; }

    public double? Fee { get; set; }

    [StringLength(100)]
    public string? SerialNo { get; set; }

    public int? Size { get; set; }

    public int? Color { get; set; }

    public int? WareHouse { get; set; }

    public bool? Amani { get; set; }

    public int Type { get; set; }

    [Column("FK_DocsysCode")]
    public int? FkDocsysCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? InvoiceDate { get; set; }

    [StringLength(300)]
    public string CustomerName { get; set; } = null!;

    public int InvoiceSerialNo { get; set; }

    [Column("FK_AccountSysCode")]
    public int? FkAccountSysCode { get; set; }

    public int SysCode { get; set; }

    public double? Quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal GrossFee { get; set; }

    [StringLength(100)]
    public string Unit { get; set; } = null!;

    public double? DiscountPercent { get; set; }

    [StringLength(1000)]
    public string? Term { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SysShamsiDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime SysDate { get; set; }

    public int InvoiceNo { get; set; }

    [StringLength(300)]
    public string Comment { get; set; } = null!;

    public double? DiscountPercent2 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DateExpire { get; set; }

    [Column(TypeName = "money")]
    public decimal DiscountFee { get; set; }

    public int? VisitorSysCodeRows { get; set; }

    [Column(TypeName = "money")]
    public decimal Cost { get; set; }

    [Column(TypeName = "money")]
    public decimal VisitorFee { get; set; }

    public float? VisitorPer { get; set; }

    [Column(TypeName = "money")]
    public decimal BenefitCost { get; set; }

    public int? Visitor1SysCode { get; set; }

    public double? TotalFee { get; set; }

    public double? AvarezAmount { get; set; }

    public double? MaliatAmount { get; set; }

    public double? DiscountAmount2 { get; set; }

    public double? DiscountAmount { get; set; }

    public double? SubTotalFee { get; set; }

    public double? UnitFee { get; set; }

    public int? VisitorSysCode2 { get; set; }

    public double? FeeNoCost { get; set; }

    public int? GoodType { get; set; }

    [StringLength(200)]
    public string? Field4 { get; set; }

    [StringLength(200)]
    public string? Field3 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? RecivedDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DelivaredDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PaymentDate { get; set; }

    public double? GoodsVisitorPer { get; set; }

    [Column("GroupID1")]
    public int? GroupId1 { get; set; }

    [Column("GroupID2")]
    public int? GroupId2 { get; set; }

    [Column("GroupID3")]
    public int? GroupId3 { get; set; }

    [StringLength(300)]
    public string? CommentRow { get; set; }

    public int? VisitorSyscode { get; set; }

    public double? TotalFeeNoMaliat { get; set; }

    public int Sign { get; set; }

    public double? UnitRate { get; set; }

    public int? RowNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InvoiceMiladiDate { get; set; }

    [StringLength(1000)]
    public string? Title { get; set; }

    [Column("Fk_ProjectID")]
    public int? FkProjectId { get; set; }

    [Column("Fk_YearId")]
    public byte FkYearId { get; set; }
}
