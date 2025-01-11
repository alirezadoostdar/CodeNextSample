using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class ChangeDocDetailTbl
{
    public int Syscode { get; set; }

    public int? FkDocSysCode { get; set; }

    public int? FkAccountSyscode { get; set; }

    public decimal? AmmountIn { get; set; }

    public decimal? AmmountOut { get; set; }

    public int? UserRowNo { get; set; }

    public string? ArchiveName { get; set; }

    public int? SndFkAccountSyscode { get; set; }

    public string? Comment { get; set; }

    public int? OnChangeUserId { get; set; }

    public DateTime? OnChangeSysDate { get; set; }

    public bool? IsUpDated { get; set; }

    public int? CombineTo { get; set; }

    public string? OnChangeSysShamsiDate { get; set; }

    public bool? IsDeleteOnServer { get; set; }
}
