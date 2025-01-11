using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwRemainGoodTolidi
{
    [Column("qty")]
    public double? Qty { get; set; }

    public int? GoodSyscode { get; set; }
}
