using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("GridsInfo")]
public partial class GridsInfo
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("STPname")]
    [StringLength(1000)]
    public string Stpname { get; set; } = null!;

    [StringLength(1000)]
    public string RefrenceName { get; set; } = null!;

    [StringLength(1000)]
    public string DisplayName { get; set; } = null!;

    public bool DefaultRef { get; set; }

    public int? OrderNo { get; set; }

    [StringLength(1000)]
    public string? RemainField { get; set; }

    [StringLength(1000)]
    public string? Field1name { get; set; }

    [StringLength(1000)]
    public string? Field2name { get; set; }

    public bool CanPolicy { get; set; }

    [StringLength(100)]
    public string? DetailRef { get; set; }

    [StringLength(100)]
    public string? RelationColumn { get; set; }

    public bool? PrintingSystem { get; set; }

    public bool? PrintOutPut { get; set; }

    public bool? MultiTable { get; set; }

    [Column("PrintStPName")]
    [StringLength(100)]
    public string? PrintStPname { get; set; }

    [StringLength(100)]
    public string? TableName { get; set; }

    [StringLength(1000)]
    public string? PolicyComment { get; set; }

    public int? PolicyLevel { get; set; }

    public bool? Disable { get; set; }

    [Column("UpdateSTP")]
    [StringLength(100)]
    public string? UpdateStp { get; set; }

    [StringLength(100)]
    public string? DeleteStp { get; set; }

    [StringLength(100)]
    public string? InsertStp { get; set; }

    [StringLength(100)]
    public string? Syscodefield { get; set; }

    public bool? AutoUpdate { get; set; }

    [InverseProperty("Fk")]
    public virtual ICollection<GridLayout> GridLayouts { get; set; } = new List<GridLayout>();

    [InverseProperty("Fk")]
    public virtual ICollection<PrintLayout> PrintLayouts { get; set; } = new List<PrintLayout>();
}
