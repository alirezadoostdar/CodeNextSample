using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class DataLog
{
    public DateTime SysDate { get; set; }

    public string Comment { get; set; } = null!;

    public int UserId { get; set; }

    public int Action { get; set; }

    public string? Source { get; set; }

    public string? SysShamsiDate { get; set; }

    public virtual InfoDataLogAction ActionNavigation { get; set; } = null!;
}
