using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
[Table("DataLog")]
public partial class DataLog
{
    [Column(TypeName = "datetime")]
    public DateTime SysDate { get; set; }

    [StringLength(4000)]
    public string Comment { get; set; } = null!;

    public int UserId { get; set; }

    public int Action { get; set; }

    [StringLength(100)]
    public string? Source { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SysShamsiDate { get; set; }

    [ForeignKey("Action")]
    public virtual InfoDataLogAction ActionNavigation { get; set; } = null!;
}
