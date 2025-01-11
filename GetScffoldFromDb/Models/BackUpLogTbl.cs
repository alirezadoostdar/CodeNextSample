using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
[Table("BackUpLogTBL")]
public partial class BackUpLogTbl
{
    [Column("UserID")]
    public int? UserId { get; set; }

    [StringLength(100)]
    public string? UserName { get; set; }

    public string? MessageErr { get; set; }

    [StringLength(1000)]
    public string? PathFile { get; set; }

    public bool? IsSuccess { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ShamsiDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MiladiDate { get; set; }

    [Column("IP")]
    [StringLength(50)]
    public string? Ip { get; set; }

    [StringLength(200)]
    public string? ComputerName { get; set; }
}
