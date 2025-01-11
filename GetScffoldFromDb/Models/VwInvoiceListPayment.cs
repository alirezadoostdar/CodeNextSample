using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwInvoiceListPayment
{
    public string? CustomerName { get; set; }

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

    [Column(TypeName = "datetime")]
    public DateTime? InvoiceMiladiDate { get; set; }

    [Column("FK_DocsysCode")]
    public int? FkDocsysCode { get; set; }

    [Column("UName")]
    [StringLength(1000)]
    public string? Uname { get; set; }

    public int InvoiceNo { get; set; }

    public bool? Amani { get; set; }

    public string? AccountName { get; set; }

    [StringLength(100)]
    public string? ArchiveName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime SysDate { get; set; }

    [StringLength(200)]
    public string? Type { get; set; }

    [Column(TypeName = "money")]
    public decimal? TotalAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal? TotalAmountWithMaliat { get; set; }

    [Column(TypeName = "money")]
    public decimal? InvoiceAmountMaliat { get; set; }

    [Column(TypeName = "money")]
    public decimal? InvoiceAmountAvarez { get; set; }

    [Column(TypeName = "money")]
    public decimal? InvoiceAmountAvarezMaliat { get; set; }

    public float? VisitorAmount1 { get; set; }

    public float? VisitorAmount2 { get; set; }

    public float? Visitor2per { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RecievedMiladiDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DeliveredMiladiDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PaymentMiladiDate { get; set; }

    public double? InvoiceWieght { get; set; }

    public string? Visitor1 { get; set; }

    public string? Visitor2 { get; set; }

    public string? Driver { get; set; }

    public string? Distributor { get; set; }

    [StringLength(100)]
    public string? Settlement { get; set; }

    public float? Visitor1per { get; set; }

    public int? VisitorSyscode { get; set; }

    [Column("FK_DocDetailSysCode")]
    public int? FkDocDetailSysCode { get; set; }

    [Column(TypeName = "money")]
    public decimal? Fee { get; set; }

    [Column("FK_InvoiceSerial")]
    public int? FkInvoiceSerial { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DocDate { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? AmountPayWithOutMaliat { get; set; }

    public int? VisitorSysCode2 { get; set; }

    [Column("Fk_ProjectID")]
    public int? FkProjectId { get; set; }

    [Column("Fk_YearId")]
    public byte FkYearId { get; set; }
}
