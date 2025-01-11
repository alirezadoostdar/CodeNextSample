using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class TaxInvoiceIssue
{
    public byte Id { get; set; }

    public string IssueTitle { get; set; } = null!;

    public virtual ICollection<TaxInvoice> TaxInvoices { get; set; } = new List<TaxInvoice>();
}
