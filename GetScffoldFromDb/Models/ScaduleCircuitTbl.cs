using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Table("ScaduleCircuitTBL")]
public partial class ScaduleCircuitTbl
{
    [Key]
    public int SysCode { get; set; }

    [Column("FK_ScaduleSysCode")]
    public int? FkScaduleSysCode { get; set; }

    [Column("SendUserID")]
    public int? SendUserId { get; set; }

    [Column("RecevieUserID")]
    public int? RecevieUserId { get; set; }

    [Column(TypeName = "ntext")]
    public string? Comment { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SysDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ShamsiSysDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FollowDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? FollowShamsiDate { get; set; }

    [ForeignKey("RecevieUserId")]
    [InverseProperty("ScaduleCircuitTblRecevieUsers")]
    public virtual User? RecevieUser { get; set; }

    [ForeignKey("SendUserId")]
    [InverseProperty("ScaduleCircuitTblSendUsers")]
    public virtual User? SendUser { get; set; }
}
