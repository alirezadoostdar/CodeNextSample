using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class Visit
{
    public int Id { get; set; }

    public int FkAccountSysCode { get; set; }

    public int FkVisitorSysCode { get; set; }

    public int? FkInvoiceSerialNo { get; set; }

    public string ShamsiDate { get; set; } = null!;

    public DateTime MiladiDate { get; set; }

    public string? VisitsComment { get; set; }

    public bool VisitsStatus { get; set; }

    public string VisitsLong { get; set; } = null!;

    public string VisitsLat { get; set; } = null!;

    public byte? CategoryId { get; set; }

    public virtual VisitsCategory? Category { get; set; }

    public virtual CodeMngdwntbl FkAccountSysCodeNavigation { get; set; } = null!;

    public virtual InvoiceTbl? FkInvoiceSerialNoNavigation { get; set; }

    public virtual CodeMngdwntbl FkVisitorSysCodeNavigation { get; set; } = null!;
}
