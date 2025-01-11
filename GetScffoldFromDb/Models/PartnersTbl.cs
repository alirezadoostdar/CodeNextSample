using System;
using System.Collections.Generic;

namespace GetScffoldFromDb.Models;

public partial class PartnersTbl
{
    public byte Id { get; set; }

    public int? AccountSysCode { get; set; }

    public double StockPer { get; set; }

    public virtual CodeMngdwntbl? AccountSysCodeNavigation { get; set; }
}
