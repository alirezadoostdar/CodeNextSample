using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class VwLastInvoiceOfPerson
{
    public int? FkAccountSysCode { get; set; }

    public string? LastInvoiceDate { get; set; }

    public DateTime? LastInvoiceMiladiDate { get; set; }

    public int? LastDay { get; set; }

    public int? VisitorSyscode { get; set; }
}
