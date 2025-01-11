using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class InvoicePaymentTbl
{
    public int SysCode { get; set; }

    public int? FkInvoiceSerial { get; set; }

    public int? FkDocDetailSysCode { get; set; }

    public decimal? Fee { get; set; }

    public virtual DocDetailTbl? FkDocDetailSysCodeNavigation { get; set; }

    public virtual InvoiceTbl? FkInvoiceSerialNavigation { get; set; }
}
