using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("DistributionDetailTBL")]
public partial class DistributionDetailTbl
{
    [Key]
    public int SysCode { get; set; }

    [Column("FK_InvoiceSerial")]
    public int? FkInvoiceSerial { get; set; }

    [Column("FK_DistributionSerial")]
    public int? FkDistributionSerial { get; set; }

    [StringLength(1000)]
    public string Comment { get; set; } = null!;

    [StringLength(1000)]
    public string Field1 { get; set; } = null!;

    [StringLength(1000)]
    public string Field2 { get; set; } = null!;

    [StringLength(1000)]
    public string Field3 { get; set; } = null!;

    public int RowNo { get; set; }

    [ForeignKey("FkDistributionSerial")]
    [InverseProperty("DistributionDetailTbls")]
    public virtual DistributionTbl? FkDistributionSerialNavigation { get; set; }

    [ForeignKey("FkInvoiceSerial")]
    [InverseProperty("DistributionDetailTbls")]
    public virtual InvoiceTbl? FkInvoiceSerialNavigation { get; set; }
}
