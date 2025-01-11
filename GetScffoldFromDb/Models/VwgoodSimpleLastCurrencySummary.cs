using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class VwgoodSimpleLastCurrencySummary
{
    public string? InvoiceDate { get; set; }

    public decimal? CurFee { get; set; }

    public decimal BaseRate { get; set; }

    public string? CurName { get; set; }

    public int CurrencyId { get; set; }

    public decimal CurRateDef { get; set; }

    public int GoodSysCode { get; set; }

    public long? Rank { get; set; }
}
