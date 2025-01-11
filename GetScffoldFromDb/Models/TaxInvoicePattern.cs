using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class TaxInvoicePattern
{
    public byte Id { get; set; }

    public string PatternTitle { get; set; } = null!;

    public virtual ICollection<TaxInvoice> TaxInvoices { get; set; } = new List<TaxInvoice>();
}
