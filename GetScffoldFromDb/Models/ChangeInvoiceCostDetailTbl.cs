using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
[Table("ChangeInvoiceCostDetailTbl")]
public partial class ChangeInvoiceCostDetailTbl
{
    [Column("FK_FactorSerialNo")]
    public int FkFactorSerialNo { get; set; }

    [Column("FK_InvoiceCostSysCode")]
    public int FkInvoiceCostSysCode { get; set; }

    [Column(TypeName = "money")]
    public decimal? Amount { get; set; }

    public int SysCode { get; set; }

    public int? OnChangeUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OnChangeSysDate { get; set; }

    public bool? IsUpDated { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? OnChangeSysShamsiDate { get; set; }
}
