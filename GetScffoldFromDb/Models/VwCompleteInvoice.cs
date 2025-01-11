using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwCompleteInvoice
{
    public int GoodSysCode { get; set; }

    [StringLength(300)]
    public string? DetailComment { get; set; }

    public double? Quantity { get; set; }

    [Column(TypeName = "money")]
    public decimal Fee { get; set; }

    [StringLength(100)]
    public string Unit { get; set; } = null!;

    public double? UnitRate { get; set; }

    [Column(TypeName = "money")]
    public decimal? UserPrice { get; set; }

    [StringLength(100)]
    public string? SerialNo { get; set; }

    public int? Size { get; set; }

    public int? Color { get; set; }

    public int? WareHouse { get; set; }

    [Column("FK_InvoiceSysCode")]
    public int FkInvoiceSysCode { get; set; }

    public double? DiscountPercent { get; set; }

    public int SysCode { get; set; }

    [StringLength(1000)]
    public string? Term { get; set; }

    public int? RowNo { get; set; }

    [StringLength(300)]
    public string CustomerName { get; set; } = null!;

    [Column("FK_AccountSysCode")]
    public int? FkAccountSysCode { get; set; }

    [StringLength(300)]
    public string Comment { get; set; } = null!;

    public int InvoiceSerialNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? RecivedDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DelivaredDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PaymentDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? InvoiceDate { get; set; }

    [Column("FK_DocsysCode")]
    public int? FkDocsysCode { get; set; }

    [StringLength(100)]
    public string? ArchiveName { get; set; }

    public int UserNo { get; set; }

    public int InvoiceNo { get; set; }

    public int? VisitorSyscode { get; set; }

    public float? VisitorPer { get; set; }

    [Column(TypeName = "money")]
    public decimal? VisitorAmount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime SysDate { get; set; }

    public int Sign { get; set; }

    public int Type { get; set; }

    public bool? Amani { get; set; }

    public double? DiscountPercent2 { get; set; }

    [Column("Fk_YearId")]
    public byte FkYearId { get; set; }

    [Column("Fk_ProjectID")]
    public int? FkProjectId { get; set; }
}
