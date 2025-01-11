using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
[Table("DashbordLayoutTBL")]
public partial class DashbordLayoutTbl
{
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(1000)]
    public string Title { get; set; } = null!;

    [Column("XMLdata")]
    public byte[] Xmldata { get; set; } = null!;

    public bool UseCurrentDatabase { get; set; }
}
