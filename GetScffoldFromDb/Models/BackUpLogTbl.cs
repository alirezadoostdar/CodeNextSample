using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class BackUpLogTbl
{
    public int? UserId { get; set; }

    public string? UserName { get; set; }

    public string? MessageErr { get; set; }

    public string? PathFile { get; set; }

    public bool? IsSuccess { get; set; }

    public string? ShamsiDate { get; set; }

    public DateTime? MiladiDate { get; set; }

    public string? Ip { get; set; }

    public string? ComputerName { get; set; }
}
