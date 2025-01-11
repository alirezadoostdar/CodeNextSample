using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
[Table("ChangeDocTbl")]
public partial class ChangeDocTbl
{
    public int SysCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DocDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SysDate { get; set; }

    [Column("UserIDNO")]
    public int? UserIdno { get; set; }

    [StringLength(1000)]
    public string? Comment { get; set; }

    [StringLength(1000)]
    public string? ArchiveName { get; set; }

    public bool? Lock { get; set; }

    public int? OnChangeUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OnChangeSysDate { get; set; }

    public bool? IsUpDated { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? OnChangeSysShamsiDate { get; set; }
}
