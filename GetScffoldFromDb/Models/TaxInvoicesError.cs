using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class TaxInvoicesError
{
    public int Id { get; set; }

    public int? FkTaxInvoiceId { get; set; }

    public string Code { get; set; } = null!;

    public string Message { get; set; } = null!;

    public string ErrorType { get; set; } = null!;

    public byte FkTaxErrorTypeId { get; set; }

    public virtual TaxErrorType FkTaxErrorType { get; set; } = null!;

    public virtual TaxInvoice? FkTaxInvoice { get; set; }
}
