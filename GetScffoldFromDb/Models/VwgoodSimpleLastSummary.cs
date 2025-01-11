using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwgoodSimpleLastSummary
{
    [StringLength(10)]
    [Unicode(false)]
    public string? LastDate { get; set; }

    public double? LastFee { get; set; }

    public double? FeeNoCost { get; set; }

    [StringLength(300)]
    public string LastSeller { get; set; } = null!;

    public int GoodSysCode { get; set; }

    public long? Rank { get; set; }
}
