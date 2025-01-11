using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
[Table("ChangeDocDetailTbl")]
public partial class ChangeDocDetailTbl
{
    public int Syscode { get; set; }

    [Column("Fk_docSysCode")]
    public int? FkDocSysCode { get; set; }

    [Column("Fk_AccountSyscode")]
    public int? FkAccountSyscode { get; set; }

    [Column("AmmountIN", TypeName = "money")]
    public decimal? AmmountIn { get; set; }

    [Column("AmmountOUT", TypeName = "money")]
    public decimal? AmmountOut { get; set; }

    public int? UserRowNo { get; set; }

    [StringLength(1000)]
    public string? ArchiveName { get; set; }

    [Column("SndFk_AccountSyscode")]
    public int? SndFkAccountSyscode { get; set; }

    [StringLength(1000)]
    public string? Comment { get; set; }

    public int? OnChangeUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OnChangeSysDate { get; set; }

    public bool? IsUpDated { get; set; }

    public int? CombineTo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? OnChangeSysShamsiDate { get; set; }

    public bool? IsDeleteOnServer { get; set; }
}
