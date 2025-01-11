using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
[Table("ChangeCheckOUTTBL")]
public partial class ChangeCheckOuttbl
{
    public long SerialNo { get; set; }

    [StringLength(1000)]
    public string Comment { get; set; } = null!;

    [Column("FK_BankAccount")]
    public int FkBankAccount { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CheckDate { get; set; }

    [Column("FK_DocSysCode")]
    public int FkDocSysCode { get; set; }

    public int? OnChangeUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? OnChangeSysDate { get; set; }

    public bool? IsUpDated { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? OnChangeSysShamsiDate { get; set; }

    public int? Belongto { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CheckMiladiDate { get; set; }
}
