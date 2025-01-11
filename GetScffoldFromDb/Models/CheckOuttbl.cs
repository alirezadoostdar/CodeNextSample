using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("CheckOUTTBL")]
public partial class CheckOuttbl
{
    public long SerialNo { get; set; }

    [StringLength(1000)]
    public string Comment { get; set; } = null!;

    [Column("FK_BankAccount")]
    public int FkBankAccount { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? CheckDate { get; set; }

    [Key]
    [Column("FK_DocSysCode")]
    public int FkDocSysCode { get; set; }

    public int? Belongto { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CheckMiladiDate { get; set; }

    [ForeignKey("Belongto")]
    [InverseProperty("CheckOuttbls")]
    public virtual CodeMngdwntbl? BelongtoNavigation { get; set; }

    [ForeignKey("FkBankAccount")]
    [InverseProperty("CheckOuttbls")]
    public virtual BanksTbl FkBankAccountNavigation { get; set; } = null!;

    [ForeignKey("FkDocSysCode")]
    [InverseProperty("CheckOuttbl")]
    public virtual DocDetailTbl FkDocSysCodeNavigation { get; set; } = null!;
}
