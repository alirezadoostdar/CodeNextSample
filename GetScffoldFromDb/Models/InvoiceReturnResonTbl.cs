using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class InvoiceReturnResonTbl
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public virtual ICollection<InvoiceTbl> InvoiceTbls { get; set; } = new List<InvoiceTbl>();
}
