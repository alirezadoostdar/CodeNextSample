using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("SqlErrMsg")]
public partial class SqlErrMsg
{
    [Key]
    [Column("msgnum")]
    public int Msgnum { get; set; }

    [Column("severity")]
    public int Severity { get; set; }

    [Column("msgtext")]
    [StringLength(1000)]
    public string Msgtext { get; set; } = null!;

    [Column("msgtext_EN")]
    [StringLength(1000)]
    public string MsgtextEn { get; set; } = null!;

    [Column("replace")]
    [StringLength(100)]
    public string Replace { get; set; } = null!;
}
