using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class BankDetailTbl
{
    public int FkDocDetailsyscode { get; set; }

    public string Number { get; set; } = null!;

    public bool IsPos { get; set; }

    public virtual DocDetailTbl FkDocDetailsyscodeNavigation { get; set; } = null!;
}
