using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwgoodAvrageFee
{
    public int GoodSysCode { get; set; }

    [Column(TypeName = "money")]
    public decimal? AvgFee { get; set; }
}
