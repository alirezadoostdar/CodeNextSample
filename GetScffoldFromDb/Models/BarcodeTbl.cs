using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("BarcodeTbl")]
public partial class BarcodeTbl
{
    public int GoodCode { get; set; }

    [StringLength(1000)]
    public string? Field1 { get; set; }

    [StringLength(1000)]
    public string? Field2 { get; set; }

    [Key]
    public int SysId { get; set; }

    public int? Quantity { get; set; }

    public int? Color { get; set; }

    public int? Size { get; set; }

    [ForeignKey("GoodCode")]
    [InverseProperty("BarcodeTbls")]
    public virtual StockTbl GoodCodeNavigation { get; set; } = null!;
}
