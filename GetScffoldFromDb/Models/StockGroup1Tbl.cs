using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("stockGroup1Tbl")]
public partial class StockGroup1Tbl
{
    [Key]
    public int GroupId { get; set; }

    [StringLength(100)]
    public string GroupName { get; set; } = null!;

    [InverseProperty("GroupId1Navigation")]
    public virtual ICollection<StockTbl> StockTbls { get; set; } = new List<StockTbl>();
}
