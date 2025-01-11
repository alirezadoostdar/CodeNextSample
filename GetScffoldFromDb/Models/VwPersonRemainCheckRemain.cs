using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwPersonRemainCheckRemain
{
    public int AccountSysCode { get; set; }

    [Column(TypeName = "money")]
    public decimal? Remain { get; set; }

    [Column(TypeName = "money")]
    public decimal? CheckRemain { get; set; }
}
