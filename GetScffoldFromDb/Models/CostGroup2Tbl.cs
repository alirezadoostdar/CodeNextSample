using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("CostGroup2Tbl")]
public partial class CostGroup2Tbl
{
    [Key]
    public int GroupId { get; set; }

    [StringLength(100)]
    public string GroupName { get; set; } = null!;

    [InverseProperty("GroupId2Navigation")]
    public virtual ICollection<CostTbl> CostTbls { get; set; } = new List<CostTbl>();
}
