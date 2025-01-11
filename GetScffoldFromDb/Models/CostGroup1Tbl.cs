using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("CostGroup1Tbl")]
[Index("GroupName", Name = "IX_CostGroup1Tbl", IsUnique = true)]
public partial class CostGroup1Tbl
{
    [Key]
    public int GroupId { get; set; }

    [StringLength(100)]
    public string GroupName { get; set; } = null!;

    [InverseProperty("GroupId1Navigation")]
    public virtual ICollection<CostTbl> CostTbls { get; set; } = new List<CostTbl>();
}
