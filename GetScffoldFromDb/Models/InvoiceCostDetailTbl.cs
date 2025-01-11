using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("InvoiceCostDetailTbl")]
public partial class InvoiceCostDetailTbl
{
    [Column("FK_FactorSerialNo")]
    public int FkFactorSerialNo { get; set; }

    [Column("FK_InvoiceCostSysCode")]
    public int FkInvoiceCostSysCode { get; set; }

    [Column(TypeName = "money")]
    public decimal? Amount { get; set; }

    [Key]
    public int SysCode { get; set; }

    [Column(TypeName = "money")]
    public decimal? CurAmount { get; set; }

    [ForeignKey("FkFactorSerialNo")]
    [InverseProperty("InvoiceCostDetailTbls")]
    public virtual InvoiceTbl FkFactorSerialNoNavigation { get; set; } = null!;

    [ForeignKey("FkInvoiceCostSysCode")]
    [InverseProperty("InvoiceCostDetailTbls")]
    public virtual InvoiceCostTbl FkInvoiceCostSysCodeNavigation { get; set; } = null!;
}
