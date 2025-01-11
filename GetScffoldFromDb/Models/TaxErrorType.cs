using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class TaxErrorType
{
    public byte Id { get; set; }

    public string ErrorTitle { get; set; } = null!;

    public virtual ICollection<TaxInvoicesError> TaxInvoicesErrors { get; set; } = new List<TaxInvoicesError>();
}
