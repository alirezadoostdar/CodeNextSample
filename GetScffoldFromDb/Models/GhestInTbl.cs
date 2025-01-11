using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class GhestInTbl
{
    public int SysCode { get; set; }

    public string Comment { get; set; } = null!;

    public string? Date { get; set; }

    public int FkDocSysCode { get; set; }

    public int SerialNo { get; set; }

    public int? Belongto { get; set; }

    public bool? Smssent { get; set; }

    public DateTime? MiladiDate { get; set; }

    public string? PassDate { get; set; }

    public DateTime? PassMiladiDate { get; set; }

    public double? Benefit { get; set; }

    public virtual CodeMngdwntbl? BelongtoNavigation { get; set; }

    public virtual DocDetailTbl FkDocSysCodeNavigation { get; set; } = null!;
}
