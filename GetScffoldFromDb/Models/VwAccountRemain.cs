using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwAccountRemain
{
    [Column(TypeName = "money")]
    public decimal? Remain { get; set; }

    public int Account { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? LastDate { get; set; }

    [Column(TypeName = "money")]
    public decimal? Cur1Amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? Cur2Amount { get; set; }

    [Column(TypeName = "money")]
    public decimal? Cur3Amount { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastMiladiDate { get; set; }
}
