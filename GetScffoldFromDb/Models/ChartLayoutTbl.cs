using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("ChartLayoutTBL")]
public partial class ChartLayoutTbl
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(1000)]
    public string ChartName { get; set; } = null!;

    [Column("XMLdata")]
    public byte[] Xmldata { get; set; } = null!;

    [Column("FK_UID")]
    public int FkUid { get; set; }

    [StringLength(10)]
    public string? Lang { get; set; }
}
