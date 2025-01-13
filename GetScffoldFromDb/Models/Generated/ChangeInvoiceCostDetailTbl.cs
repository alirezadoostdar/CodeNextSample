using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class ChangeInvoiceCostDetailTbl
{
    public int FkFactorSerialNo { get; set; }

    public int FkInvoiceCostSysCode { get; set; }

    public decimal? Amount { get; set; }

    public int SysCode { get; set; }

    public int? OnChangeUserId { get; set; }

    public DateTime? OnChangeSysDate { get; set; }

    public bool? IsUpDated { get; set; }

    public string? OnChangeSysShamsiDate { get; set; }
}
