using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("GridFilterTitleTbl")]
public partial class GridFilterTitleTbl
{
    [Key]
    public int SysCode { get; set; }

    public int LayoutId { get; set; }

    [StringLength(1000)]
    public string DisplayText { get; set; } = null!;

    [InverseProperty("FkFilter")]
    public virtual ICollection<GridLayOutFilterTbl> GridLayOutFilterTbls { get; set; } = new List<GridLayOutFilterTbl>();
}
