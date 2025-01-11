using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class VwPersonRemainCheckRemain
{
    public int AccountSysCode { get; set; }

    public decimal? Remain { get; set; }

    public decimal? CheckRemain { get; set; }
}
