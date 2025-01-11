using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwgoodSimpleLastCurrencySummary
{
    [StringLength(10)]
    [Unicode(false)]
    public string? InvoiceDate { get; set; }

    [Column(TypeName = "money")]
    public decimal? CurFee { get; set; }

    [Column(TypeName = "money")]
    public decimal BaseRate { get; set; }

    [StringLength(50)]
    public string? CurName { get; set; }

    [Column("CurrencyID")]
    public int CurrencyId { get; set; }

    [Column(TypeName = "money")]
    public decimal CurRateDef { get; set; }

    public int GoodSysCode { get; set; }

    public long? Rank { get; set; }
}
