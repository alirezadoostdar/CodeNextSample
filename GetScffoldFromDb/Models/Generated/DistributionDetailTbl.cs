using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class DistributionDetailTbl
{
    public int SysCode { get; set; }

    public int? FkInvoiceSerial { get; set; }

    public int? FkDistributionSerial { get; set; }

    public string Comment { get; set; } = null!;

    public string Field1 { get; set; } = null!;

    public string Field2 { get; set; } = null!;

    public string Field3 { get; set; } = null!;

    public int RowNo { get; set; }

    public virtual DistributionTbl? FkDistributionSerialNavigation { get; set; }

    public virtual InvoiceTbl? FkInvoiceSerialNavigation { get; set; }
}
