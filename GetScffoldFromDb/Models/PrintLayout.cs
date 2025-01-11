using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

public partial class PrintLayout
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

    public bool CanPolicy { get; set; }

    [InverseProperty("FkPrintLayout")]
    public virtual ICollection<DefaultPrintInfoLay> DefaultPrintInfoLays { get; set; } = new List<DefaultPrintInfoLay>();

    [ForeignKey("Fkid")]
    [InverseProperty("PrintLayouts")]
    public virtual GridsInfo Fk { get; set; } = null!;
}
