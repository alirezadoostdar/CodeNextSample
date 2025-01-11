using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GetScffoldFromDb.Models;

[Keyless]
[Table("GPSTrackingTBL")]
public partial class GpstrackingTbl
{
    [Column("Fk_AccountSysCode")]
    public int FkAccountSysCode { get; set; }

    public DateOnly TrackingDate { get; set; }

    public byte TrackingHour { get; set; }

    public byte TrackingMinute { get; set; }

    [StringLength(15)]
    public string Lat { get; set; } = null!;

    [StringLength(15)]
    public string Long { get; set; } = null!;

    public long TrackingId { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string ShamsiDate { get; set; } = null!;

    [Column("DT", TypeName = "datetime")]
    public DateTime Dt { get; set; }

    [ForeignKey("FkAccountSysCode")]
    public virtual CodeMngdwntbl FkAccountSysCodeNavigation { get; set; } = null!;
}
