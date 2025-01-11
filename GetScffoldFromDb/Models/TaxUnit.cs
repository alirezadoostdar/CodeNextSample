using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("TaxUnit")]
public partial class TaxUnit
{
    [Key]
    public int Id { get; set; }

    [StringLength(50)]
    public string Unit { get; set; } = null!;

    [InverseProperty("FkTaxUnit")]
    public virtual ICollection<StockTbl> StockTbls { get; set; } = new List<StockTbl>();
}
