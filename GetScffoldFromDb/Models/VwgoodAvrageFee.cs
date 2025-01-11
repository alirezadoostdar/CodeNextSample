using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class VwgoodAvrageFee
{
    public int GoodSysCode { get; set; }

    public decimal? AvgFee { get; set; }
}
