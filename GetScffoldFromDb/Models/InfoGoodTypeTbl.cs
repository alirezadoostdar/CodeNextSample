using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("infoGoodTypeTbl")]
public partial class InfoGoodTypeTbl
{
    [StringLength(1000)]
    public string Title { get; set; } = null!;

    [Key]
    public int Code { get; set; }

    [InverseProperty("TypeNavigation")]
    public virtual ICollection<StockTbl> StockTbls { get; set; } = new List<StockTbl>();
}
