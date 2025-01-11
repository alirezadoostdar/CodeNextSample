using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("GhestInTBL")]
public partial class GhestInTbl
{
    public int SysCode { get; set; }

    [StringLength(1000)]
    public string Comment { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? Date { get; set; }

    [Key]
    [Column("FK_DocSysCode")]
    public int FkDocSysCode { get; set; }

    public int SerialNo { get; set; }

    public int? Belongto { get; set; }

    [Column("SMSsent")]
    public bool? Smssent { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MiladiDate { get; set; }

    [StringLength(10)]
    public string? PassDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PassMiladiDate { get; set; }

    public double? Benefit { get; set; }

    [ForeignKey("Belongto")]
    [InverseProperty("GhestInTbls")]
    public virtual CodeMngdwntbl? BelongtoNavigation { get; set; }

    [ForeignKey("FkDocSysCode")]
    [InverseProperty("GhestInTbl")]
    public virtual DocDetailTbl FkDocSysCodeNavigation { get; set; } = null!;
}
