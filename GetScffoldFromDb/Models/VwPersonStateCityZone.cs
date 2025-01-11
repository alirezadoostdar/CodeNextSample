using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class VwPersonStateCityZone
{
    public string? Title { get; set; }

    public int? FkIdcity { get; set; }

    public int? FkIdostan { get; set; }

    public int? FkZone { get; set; }

    public string? Zone { get; set; }

    public string? State { get; set; }

    public string? City { get; set; }

    public int? AccountSysCode { get; set; }
}
