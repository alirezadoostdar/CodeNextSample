using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class ScaduleCircuitTbl
{
    public int SysCode { get; set; }

    public int? FkScaduleSysCode { get; set; }

    public int? SendUserId { get; set; }

    public int? RecevieUserId { get; set; }

    public string? Comment { get; set; }

    public DateTime? SysDate { get; set; }

    public string? ShamsiSysDate { get; set; }

    public DateTime? FollowDate { get; set; }

    public string? FollowShamsiDate { get; set; }

    public virtual User? RecevieUser { get; set; }

    public virtual User? SendUser { get; set; }
}
