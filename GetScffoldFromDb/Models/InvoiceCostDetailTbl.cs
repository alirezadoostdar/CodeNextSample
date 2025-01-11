using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class InvoiceCostDetailTbl
{
    public int FkFactorSerialNo { get; set; }

    public int FkInvoiceCostSysCode { get; set; }

    public decimal? Amount { get; set; }

    public int SysCode { get; set; }

    public decimal? CurAmount { get; set; }

    public virtual InvoiceTbl FkFactorSerialNoNavigation { get; set; } = null!;

    public virtual InvoiceCostTbl FkInvoiceCostSysCodeNavigation { get; set; } = null!;
}
