using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class ChangeBankDetailTbl
{
    public int FkDocDetailsyscode { get; set; }

    public string Number { get; set; } = null!;

    public int? OnChangeUserId { get; set; }

    public DateTime? OnChangeSysDate { get; set; }

    public bool? IsUpDated { get; set; }

    public string OnChangeSysShamsiDate { get; set; } = null!;
}
