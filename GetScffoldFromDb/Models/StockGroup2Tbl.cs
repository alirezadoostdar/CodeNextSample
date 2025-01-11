using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("stockGroup2Tbl")]
public partial class StockGroup2Tbl
{
    [Key]
    public int GroupId { get; set; }

    [StringLength(100)]
    public string GroupName { get; set; } = null!;

    public float? VisitPercent { get; set; }

    [InverseProperty("GroupId2Navigation")]
    public virtual ICollection<StockTbl> StockTbls { get; set; } = new List<StockTbl>();
}
