using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class ChangeGhestInTbl
{
    public int SysCode { get; set; }

    public string Comment { get; set; } = null!;

    public string? Date { get; set; }

    public int FkDocSysCode { get; set; }

    public int SerialNo { get; set; }

    public int? OnChangeUserId { get; set; }

    public DateTime? OnChangeSysDate { get; set; }

    public bool? IsUpDated { get; set; }

    public string? OnChangeSysShamsiDate { get; set; }

    public int? Belongto { get; set; }
}
