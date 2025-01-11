using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

public partial class GridLayout
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(200)]
    public string LayoutName { get; set; } = null!;

    [Column("XMLdata")]
    public byte[] Xmldata { get; set; } = null!;

    public bool PrimaryLayout { get; set; }

    [Column("FKID")]
    public int Fkid { get; set; }

    public bool? CanPolicy { get; set; }

    [ForeignKey("Fkid")]
    [InverseProperty("GridLayouts")]
    public virtual GridsInfo Fk { get; set; } = null!;
}
