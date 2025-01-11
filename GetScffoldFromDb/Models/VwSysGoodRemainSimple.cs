using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
public partial class VwSysGoodRemainSimple
{
    [Column("QTY")]
    public double? Qty { get; set; }

    public int GoodSysCode { get; set; }
}
