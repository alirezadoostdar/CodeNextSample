using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class PersonCostMountlyTbl
{
    public int FkAccountSysCode { get; set; }

    public int FkPersonCostMountLy { get; set; }

    public double Qty { get; set; }

    public decimal Amount { get; set; }

    public bool Isactive { get; set; }

    public virtual CodeMngdwntbl FkAccountSysCodeNavigation { get; set; } = null!;

    public virtual PersonCostMountlyTbl1 FkPersonCostMountLyNavigation { get; set; } = null!;
}
