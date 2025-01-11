using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class PosTransactionTbl
{
    public int SysCode { get; set; }

    public int? InvoiceSerial { get; set; }

    public int? InvoiceNo { get; set; }

    public decimal? Amount { get; set; }

    public int? ErrCode { get; set; }

    public string? ErrMsg { get; set; }

    public DateTime? SysDate { get; set; }

    public string? SysShamsiDate { get; set; }

    public string? CardNumber { get; set; }

    public string? MerchantId { get; set; }

    public string? Rrn { get; set; }

    public string? Stan { get; set; }

    public string? TerminalId { get; set; }

    public string? TranType { get; set; }

    public string? CustomerName { get; set; }

    public int? DocCode { get; set; }

    public int? DetailCode { get; set; }
}
