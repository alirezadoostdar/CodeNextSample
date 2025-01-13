using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class DiscountCardTransactionTbl
{
    public int SysCode { get; set; }

    public int? TransactionId { get; set; }

    public decimal? TransactionDedicatedCredit { get; set; }

    public decimal? TotalDedicatedCredit { get; set; }

    public int? FkSerialInvoiceNo { get; set; }

    public string? Err { get; set; }

    public string? CardNo { get; set; }

    public DateTime? SysDate { get; set; }

    public string? SysShamsiDate { get; set; }

    public decimal? InvoiceAmount { get; set; }

    public bool? UseCredit { get; set; }

    public bool? Checked { get; set; }
}
