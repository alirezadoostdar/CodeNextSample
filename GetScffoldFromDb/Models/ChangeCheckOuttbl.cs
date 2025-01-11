using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class ChangeCheckOuttbl
{
    public long SerialNo { get; set; }

    public string Comment { get; set; } = null!;

    public int FkBankAccount { get; set; }

    public string? CheckDate { get; set; }

    public int FkDocSysCode { get; set; }

    public int? OnChangeUserId { get; set; }

    public DateTime? OnChangeSysDate { get; set; }

    public bool? IsUpDated { get; set; }

    public string? OnChangeSysShamsiDate { get; set; }

    public int? Belongto { get; set; }

    public DateTime? CheckMiladiDate { get; set; }
}
