using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("PosTransactionTBL")]
public partial class PosTransactionTbl
{
    [Key]
    public int SysCode { get; set; }

    public int? InvoiceSerial { get; set; }

    public int? InvoiceNo { get; set; }

    [Column(TypeName = "money")]
    public decimal? Amount { get; set; }

    public int? ErrCode { get; set; }

    public string? ErrMsg { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SysDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SysShamsiDate { get; set; }

    [StringLength(50)]
    public string? CardNumber { get; set; }

    public string? MerchantId { get; set; }

    [Column("RRN")]
    public string? Rrn { get; set; }

    public string? Stan { get; set; }

    public string? TerminalId { get; set; }

    public string? TranType { get; set; }

    public string? CustomerName { get; set; }

    public int? DocCode { get; set; }

    public int? DetailCode { get; set; }
}
