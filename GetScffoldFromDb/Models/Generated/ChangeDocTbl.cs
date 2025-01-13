using System;
using System.Collections.Generic;

namespace PizzaShop.Models;

public partial class ChangeDocTbl
{
    public int SysCode { get; set; }

    public string? DocDate { get; set; }

    public DateTime? SysDate { get; set; }

    public int? UserIdno { get; set; }

    public string? Comment { get; set; }

    public string? ArchiveName { get; set; }

    public bool? Lock { get; set; }

    public int? OnChangeUserId { get; set; }

    public DateTime? OnChangeSysDate { get; set; }

    public bool? IsUpDated { get; set; }

    public string? OnChangeSysShamsiDate { get; set; }
}
