using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwAccountGhestInUnPassSum
{
    [Column(TypeName = "money")]
    public decimal? Remain { get; set; }

    public int? AccountCode { get; set; }

    [Column(TypeName = "money")]
    public decimal? Cur1Amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? Cur2Amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? Cur3Amount { get; set; }
}
