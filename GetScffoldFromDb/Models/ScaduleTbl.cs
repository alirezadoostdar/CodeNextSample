using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
[Table("ScaduleTbl")]
public partial class ScaduleTbl
{
    public int SysCode { get; set; }

    [StringLength(4000)]
    public string Comment { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? DateS { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime TimeS { get; set; }

    public int UserId { get; set; }

    public bool? Viwed { get; set; }

    public int? DocCode { get; set; }

    [StringLength(1000)]
    public string Title { get; set; } = null!;

    public bool Finished { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime SysDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ShamsiSysDate { get; set; } = null!;

    [Column("FK_PersonID")]
    public int? FkPersonId { get; set; }

    [Column("Fk_GoodSysCode")]
    public int? FkGoodSysCode { get; set; }

    [Column("ReceiveUserID")]
    public int ReceiveUserId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FinishSysDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? FinishShamsiDate { get; set; }

    public int? FinishUserId { get; set; }

    [ForeignKey("FkGoodSysCode")]
    public virtual StockTbl? FkGoodSysCodeNavigation { get; set; }

    [ForeignKey("FkPersonId")]
    public virtual CodeMngdwntbl? FkPerson { get; set; }

    [ForeignKey("ReceiveUserId")]
    public virtual User ReceiveUser { get; set; } = null!;
}
