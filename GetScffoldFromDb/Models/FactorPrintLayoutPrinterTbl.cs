using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
[Table("FactorPrintLayout_PrinterTBL")]
public partial class FactorPrintLayoutPrinterTbl
{
    public int LayOutId { get; set; }

    [StringLength(1000)]
    public string? PrinterName { get; set; }

    public bool? Active { get; set; }

    public int? UserId { get; set; }
}
