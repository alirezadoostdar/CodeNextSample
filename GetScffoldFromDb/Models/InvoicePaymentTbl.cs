using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("InvoicePaymentTbl")]
public partial class InvoicePaymentTbl
{
    [Key]
    public int SysCode { get; set; }

    [Column("FK_InvoiceSerial")]
    public int? FkInvoiceSerial { get; set; }

    [Column("FK_DocDetailSysCode")]
    public int? FkDocDetailSysCode { get; set; }

    [Column(TypeName = "money")]
    public decimal? Fee { get; set; }

    [ForeignKey("FkDocDetailSysCode")]
    [InverseProperty("InvoicePaymentTbls")]
    public virtual DocDetailTbl? FkDocDetailSysCodeNavigation { get; set; }

    [ForeignKey("FkInvoiceSerial")]
    [InverseProperty("InvoicePaymentTbls")]
    public virtual InvoiceTbl? FkInvoiceSerialNavigation { get; set; }
}
