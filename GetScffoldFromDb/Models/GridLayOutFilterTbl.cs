using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("GridLayOutFilterTbl")]
public partial class GridLayOutFilterTbl
{
    [StringLength(1000)]
    public string Field { get; set; } = null!;

    [StringLength(1000)]
    public string FilterText { get; set; } = null!;

    [Key]
    public int SysCode { get; set; }

    [Column("FK_FilterId")]
    public int? FkFilterId { get; set; }

    [ForeignKey("FkFilterId")]
    [InverseProperty("GridLayOutFilterTbls")]
    public virtual GridFilterTitleTbl? FkFilter { get; set; }
}
