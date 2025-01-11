using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class VwTaxErrorComplete
{
    public int Id { get; set; }

    public int? FkTaxInvoiceId { get; set; }

    public string Code { get; set; } = null!;

    public string Message { get; set; } = null!;

    public string ErrorType { get; set; } = null!;

    public byte FkTaxErrorTypeId { get; set; }

    public string ErrorTitle { get; set; } = null!;
}
