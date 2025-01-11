using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
[Table("ChangeInvoiceTbl")]
public partial class ChangeInvoiceTbl
{
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

    public int? OnChangeUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OnChangeSysDate { get; set; }

    public bool? IsUpDated { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? OnChangeSysShamsiDate { get; set; }

    public int? VisitorSysCode2 { get; set; }

    public int? DriversSysCode { get; set; }

    public int? DistributorSysCode { get; set; }

    public int? SettlementSysCode { get; set; }

    public bool? IsDeleteOnServer { get; set; }
}
