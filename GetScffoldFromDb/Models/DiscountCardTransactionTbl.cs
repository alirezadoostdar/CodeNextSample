using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("DiscountCardTransactionTbl")]
public partial class DiscountCardTransactionTbl
{
    [Key]
    public int SysCode { get; set; }

    public int? TransactionId { get; set; }

    [Column(TypeName = "money")]
    public decimal? TransactionDedicatedCredit { get; set; }

    [Column(TypeName = "money")]
    public decimal? TotalDedicatedCredit { get; set; }

    [Column("FK_SerialInvoiceNo")]
    public int? FkSerialInvoiceNo { get; set; }

    [StringLength(1000)]
    public string? Err { get; set; }

    [StringLength(16)]
    public string? CardNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SysDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SysShamsiDate { get; set; }

    [Column(TypeName = "money")]
    public decimal? InvoiceAmount { get; set; }

    public bool? UseCredit { get; set; }

    [Column("checked")]
    public bool? Checked { get; set; }
}
